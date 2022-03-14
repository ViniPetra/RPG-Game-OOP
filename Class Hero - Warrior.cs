using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD
{
    internal class Warrior : Hero
    {
        //Atributes

        //Getters and Setters

        //Empty constructor
        public Warrior()
        {

        }

        //Constructor
        public Warrior(string name, int age, int level, Hero_Status status) : base(name, age, level, status)
        {

        }
    }
}
