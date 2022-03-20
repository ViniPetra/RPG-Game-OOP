using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD
{
    internal class Goblin : Monster
    {
        public Goblin()
        {

        }

        public Goblin(string name, int level, Monster_Status status) : base(name, level, status)
        {

        }
    }
}
