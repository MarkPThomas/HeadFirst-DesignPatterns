using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGeneration.Model
{
    public class DynamicPlayerGeneratedMonster : IMonster
    {
        public string Name { get; private set; }

        public MonsterTypes Type { get; private set; }

        private bool _isEvil;
        public bool IsEvil { get { return _isEvil; } }

        public DynamicPlayerGeneratedMonster()
        {
            _isEvil = true;
        }

        public DynamicPlayerGeneratedMonster(string name, MonsterTypes type)
        {
            _isEvil = false;
            Initialize(name, type);
        }

        public void Initialize(string name, MonsterTypes type)
        {
            Name = name;
            Type = type;
        }

        public object Clone()
        {
            DynamicPlayerGeneratedMonster clone = new DynamicPlayerGeneratedMonster();
            clone.Name = Name;
            clone.Type = Type;

            clone._isEvil = _isEvil;

            return clone;
        }

        public override string ToString()
        {
            string message = string.Format("Hello, my name is {0} and I am a {1} of type {2}. \nAm I evil? {3}", Name, this.GetType().Name, Type, IsEvil);
            return message;
        }
    }
}
