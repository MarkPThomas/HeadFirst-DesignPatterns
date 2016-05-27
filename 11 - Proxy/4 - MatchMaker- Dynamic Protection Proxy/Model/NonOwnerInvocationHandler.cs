using System;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;

namespace MatchMaker.Model
{
    public class NonOwnerInvocationHandler<IPersonBean> : RealProxy
    {
        private IPersonBean _personBean;

        private NonOwnerInvocationHandler(IPersonBean personBean)
            : base(typeof(IPersonBean))
        {
            _personBean = personBean;
        }

        public static IPersonBean Create(IPersonBean personBean)
        {
            return (IPersonBean)new NonOwnerInvocationHandler<IPersonBean>(personBean).GetTransparentProxy();
        }

        public override IMessage Invoke(IMessage msg)
        {
            var methodCall = (IMethodCallMessage)msg;
            var method = (MethodInfo)methodCall.MethodBase;

            if (method.Name.StartsWith("get_"))
            {
                return ValidInvoke(method, methodCall);
            }
            else if (method.Name.Equals("set_HotOrNot"))
            {
                return ValidInvoke(method, methodCall);
            }
            else if (method.Name.Equals("Post"))
            {
                throw new UnauthorizedAccessException(illegalAccessMessage(method.Name));
            }
            else if (method.Name.StartsWith("set_"))
            {
                throw new UnauthorizedAccessException(illegalAccessMessage(method.Name));
            }
            else
            {
                return ValidInvoke(method, methodCall);
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

