using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameSaver.Model;

namespace GameSaver.Tests
{
    public class Client
    {
        public static void Run()
        {
            MasterGameObject mgo = new MasterGameObject();

            Console.WriteLine(mgo);

            Console.WriteLine("\nWhen new level is reached ...");
            object saved = mgo.GetCurrentState();

            mgo.ChangeCurrentState();
            Console.WriteLine(mgo);

            Console.WriteLine("\nWhen a restore is required ...");
            mgo.RestoreState(saved);
            Console.WriteLine(mgo);
        }
    }
}
