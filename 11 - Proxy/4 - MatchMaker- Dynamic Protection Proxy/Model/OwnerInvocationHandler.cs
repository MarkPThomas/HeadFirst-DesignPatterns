using System;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;

namespace MatchMaker.Model
{
    public class OwnerInvocationHandler<IPersonBean> : RealProxy
    {
        private IPersonBean _personBean;

        private OwnerInvocationHandler(IPersonBean personBean)
            : base(typeof(IPersonBean))
        {
            _personBean = personBean;
        }

        public static IPersonBean Create(IPersonBean personBean)
        {
            return (IPersonBean)new OwnerInvocationHandler<IPersonBean>(personBean).GetTransparentProxy();
        }

        public override IMessage Invoke(IMessage msg)
        {
            var methodCall = (IMethodCallMessage)msg;
            var method = (MethodInfo)methodCall.MethodBase;

            try
            {
                if (method.Name.StartsWith("get_"))
                {
                    return ValidInvoke(method, methodCall);
                }
                else if (method.Name.Equals("set_HotOrNot")) 
                {
                    throw new UnauthorizedAccessException("Can't set " + method.Name + " from owner proxy.");
                }
                else if (method.Name.Equals("Poke"))
                {
                    throw new UnauthorizedAccessException("Can't set " + method.Name + " from owner proxy.");
                }
                else if (method.Name.StartsWith("set_"))
                {
                    return ValidInvoke(method, methodCall);
                }
                else
                {
                    return ValidInvoke(method, methodCall);
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine("Exception: " + e);
                //if (e is TargetInvocationException && e.InnerException != null)
                //{
                //    return new ReturnMessage(e.InnerException, msg as IMethodCallMessage);
                //}

                //return new ReturnMessage(e, msg as IMethodCallMessage);
                throw e;
            }
        }

        private IMessage ValidInvoke(MethodInfo method, IMethodCallMessage methodCall)
        {
            var result = method.Invoke(_personBean, methodCall.InArgs);
            return new ReturnMessage(result, null, 0, methodCall.LogicalCallContext, methodCall);
        }

        private string illegalAccessMessage(string methodName)
        {
            return "Can't set " + methodName + " from owner proxy.";
        }
    }
}
