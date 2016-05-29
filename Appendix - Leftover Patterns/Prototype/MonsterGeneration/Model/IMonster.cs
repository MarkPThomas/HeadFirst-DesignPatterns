using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGeneration.Model
{
    public interface IMonster : ICloneable
    {
        string Name { get; }

        MonsterTypes Type { get; }

        bool IsEvil { get; }

        void Initialize(string name, MonsterTypes type);
    }
}
