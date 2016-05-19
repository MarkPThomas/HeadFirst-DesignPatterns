using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TurkeyDucks.Model;

namespace TurkeyDucks.Tests
{
    public class DuckTestDrive
    {
        public static void Run()
        {
            MallardDuck duck = new MallardDuck();
            ITurkey duckAdapter = new DuckAdapter(duck);

            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says ...");
            testTurkey(turkey);

            Console.WriteLine("\nThe Duck Says ...");
            testDuck(duck);

            Console.WriteLine("\nThe TurkeyAdapter says ...");
            testDuck(turkeyAdapter);

            Console.WriteLine("\nThe DuckAdapter says ...");
            testTurkey(duckAdapter);
        }

        private static void testTurkey(ITurkey turkey)
        {
            turkey.gobble();
            turkey.fly();
        }

        private static void testDuck(IDuck duck)
        {
            duck.quack();
            duck.fly();
        }
    }
}
