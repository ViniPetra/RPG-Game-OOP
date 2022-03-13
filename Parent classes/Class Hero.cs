using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD
{
    internal class Hero
    {
        //Attributes
        private string Name;
        private int age, level;
        private Hero_Status status;

        //Getters and Setters
        public string HeroName { get => Name; set => Name = value; }
        public int Age { get => age; set => age = value; }
        public int Level { get => level; set => level = value; }
        internal Hero_Status Status { get => status; set => status = value; }

        //Empy constructor
        public Hero()
        {

        }
        //Constructor
        public Hero(string name, int age, int level, Hero_Status status)
        {
            Name = name;
            Age = age;
            Level = level;
            Status = status;
        }


    }
}
