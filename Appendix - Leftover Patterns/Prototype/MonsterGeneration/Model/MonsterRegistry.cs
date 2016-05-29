using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGeneration.Model
{
    public static class MonsterRegistry
    {
        private static IMonster _correctMonster;

        private static List<IMonster> _monsters = new List<IMonster>();

        private static Random _random = new Random();

        public static void RegisterMonster(IMonster monster)
        {
            _correctMonster = monster;
        }

        public static IMonster GetMonster()
        {
            if (_correctMonster == null)
            {
                _correctMonster = new WellKnownMonster();
            }
            return (IMonster)_correctMonster.Clone();
        }

        
        public static void RegisterRandomMonster(IMonster monster)
        {
            _monsters.Add(monster);
        }

        public static IMonster GetRandomMonster()
        {
            if (_monsters.Count == 0)
            {
                _monsters.Add(new WellKnownMonster());
            }
            return _monsters[_random.Next(_monsters.Count)];
        }
    }
}
