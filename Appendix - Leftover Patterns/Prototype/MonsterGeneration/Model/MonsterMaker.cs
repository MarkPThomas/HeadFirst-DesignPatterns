using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGeneration.Model
{
    public class MonsterMaker
    {
        private Random random = new Random();
        private List<string> names = new List<string>();

        public MonsterMaker()
        {
            names = new List<string>() { "Egore",
                                            "Satan",
                                            "Boaty McBoatFace",
                                            "Draco",
                                            "Snarls",
                                            "The Great Red Dragon",
                                            "Dr. Evil"};
        }


        public IMonster MakeRandomMonster()
        {
            IMonster monster = MonsterRegistry.GetMonster();

            // Get a random monster out of the 4 types, and name out of the pre-made list
            MonsterTypes type = (MonsterTypes)random.Next(4);
            string name = names[random.Next(names.Count)];

            monster.Initialize(name, type);

            return monster;
        }

        public IMonster MakeCompletelyRandomMonster()
        {
            IMonster monster = MonsterRegistry.GetRandomMonster();

            // Get a random monster out of the 4 types, and name out of the pre-made list
            MonsterTypes type = (MonsterTypes)random.Next(4);
            string name = names[random.Next(names.Count)];

            monster.Initialize(name, type);

            return monster;
        }
    }
}
