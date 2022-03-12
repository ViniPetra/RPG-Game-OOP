using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD
{
    internal class Warior : Hero
    {
        //Atributes
        private int attack;
        private int defense;

        //Getters and Setters
        public int Attack { get => attack; set => attack = value; }
        public int Defense { get => defense; set => defense = value; }

        //Empty constructor
        public Warior()
        {

        }
        //Constructor
        public Warior(int attack, int defense)
        {
            Attack = attack;
            Defense = defense;
        }
    }
}
