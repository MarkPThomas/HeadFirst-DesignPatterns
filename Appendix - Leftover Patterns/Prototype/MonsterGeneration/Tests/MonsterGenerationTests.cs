using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MonsterGeneration.Model;

namespace MonsterGeneration.Tests
{
    public class MonsterGenerationTests
    {
        public static void Run()
        {
            MonsterMaker monsterMaker = new MonsterMaker();
            DynamicPlayerGeneratedMonster monster1 = new DynamicPlayerGeneratedMonster("Phil", MonsterTypes.Dragon);
            WellKnownMonster monster2 = new WellKnownMonster("Sally", MonsterTypes.Lizard);

            MonsterRegistry.RegisterMonster(monster1);

            Console.WriteLine("This is a random monster: ");
            Console.WriteLine(monsterMaker.MakeRandomMonster());
            Console.WriteLine();

            Console.WriteLine("This is a random monster: ");
            Console.WriteLine(monsterMaker.MakeRandomMonster());
            Console.WriteLine();

            Console.WriteLine("This is a random monster: ");
            Console.WriteLine(monsterMaker.MakeRandomMonster());
            Console.WriteLine();

            MonsterRegistry.RegisterRandomMonster(monster1);
            MonsterRegistry.RegisterRandomMonster(monster2);

            Console.WriteLine("This is a very random monster: ");
            Console.WriteLine(monsterMaker.MakeCompletelyRandomMonster());
            Console.WriteLine();

            Console.WriteLine("This is a very random monster: ");
            Console.WriteLine(monsterMaker.MakeCompletelyRandomMonster());
            Console.WriteLine();

            Console.WriteLine("This is a very random monster: ");
            Console.WriteLine(monsterMaker.MakeCompletelyRandomMonster());
            Console.WriteLine();

            Console.WriteLine("This is a very random monster: ");
            Console.WriteLine(monsterMaker.MakeCompletelyRandomMonster());
            Console.WriteLine();

            Console.WriteLine("This is a very random monster: ");
            Console.WriteLine(monsterMaker.MakeCompletelyRandomMonster());
            Console.WriteLine();
        }
    }
}
