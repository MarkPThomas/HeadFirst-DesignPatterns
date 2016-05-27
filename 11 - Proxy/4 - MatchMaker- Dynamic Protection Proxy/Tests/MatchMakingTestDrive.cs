using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MatchMaker.Model;

namespace MatchMaker.Tests
{
    public class MatchMakingTestDrive
    {
        public static void Run()
        {
            IPersonBean joe = new PersonBean() { Name="Joe", Gender="Male", Interests="Skiing", HotOrNot=10};
            IPersonBean blow = new PersonBean() { Name = "Blow", Gender = "Unknown", Interests = "Farting around", HotOrNot = 1 };

            IPersonBean ownerProxy = OwnerInvocationHandler<IPersonBean>.Create(joe);

            Console.WriteLine("Name is " + ownerProxy.Name);
            Console.WriteLine("Interests were " + ownerProxy.Interests);
            ownerProxy.Interests = "Mountain Climbing";
            Console.WriteLine("Interests set from owner proxy. They are now " + ownerProxy.Interests);
            try
            {
                ownerProxy.HotOrNot = 10;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Rating is " + ownerProxy.HotOrNot);
            Console.WriteLine(ownerProxy.Post());
            try
            {
                ownerProxy.Poke();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


            IPersonBean nonOwnerProxy = NonOwnerInvocationHandler<IPersonBean>.Create(blow);

            Console.WriteLine("Name is " + nonOwnerProxy.Name);
            Console.WriteLine("Interests were " + nonOwnerProxy.Interests);
            try
            {
                nonOwnerProxy.Interests = "Mountain Climbing";
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Rating is " + nonOwnerProxy.HotOrNot);
            nonOwnerProxy.HotOrNot = 10;
            Console.WriteLine("Rating is now " + nonOwnerProxy.HotOrNot);
            try
            {
                Console.WriteLine(nonOwnerProxy.Post());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            nonOwnerProxy.Poke();
        }
    }
}
