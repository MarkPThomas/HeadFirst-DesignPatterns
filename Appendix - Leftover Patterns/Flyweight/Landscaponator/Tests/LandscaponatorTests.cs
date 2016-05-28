using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Landscaponator.Model;

namespace Landscaponator.Tests
{
    public class LandscaponatorTests
    {
        public static void Run()
        {
            TreeManager trees = new TreeManager();
            trees.AddTree(new Point(5, 10), 5);
            trees.AddTree(new Point(10, 2), 50);
            trees.AddTree(new Point(15, 16), 100);
            trees.AddTree(new Point(20, 28), 35);
            trees.AddTree(new Point(25, 13), 53);
            trees.AddTree(new Point(2, 8), 20);
            trees.AddTree(new Point(17, 9), 25);
            trees.AddTree(new Point(24, 10), 52);

            trees.DisplayTrees();
        }
    }
}
