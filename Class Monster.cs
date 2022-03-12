using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD
{
    internal class Monster
    {
        private int level;
        private Monster_Status status;

        //Getters and Setters
        public int Level { get => level; set => level = value; }
        internal Monster_Status Status { get => status; set => status = value; }

        //Empty Constructor
        public Monster()
        {

        }

        //Constructor
        public Monster(int level, Monster_Status status)
        {
            Level = level;
            Status = status;
        }

    }
}
