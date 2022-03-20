using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD
{
    internal class Spider : Monster
    {
        //Empty constructor
        public Spider()
        {

        }

        //Constructor
        public Spider(string name, int level, Monster_Status status) : base(name, level, status)
        {

        }
    }
}
