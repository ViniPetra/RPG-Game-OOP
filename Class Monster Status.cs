using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD
{
    internal class Monster_Status
    {
        private int damage;
        private int protection;
        private int agility;
        private int luck;
        private int health;
        private int mana;

        //Getters and Setters
        public int Damage { get => damage; set => damage = value; }
        public int Protection { get => protection; set => protection = value; }
        public int Agility { get => agility; set => agility = value; }
        public int Luck { get => luck; set => luck = value; }
        public int Health { get => health; set => health = value; }
        public int Mana { get => mana; set => mana = value; }

        //Empty constructor
        public Monster_Status()
        {

        }
        //Constructor
        public Monster_Status(int damage, int protection, int agility, int luck, int health, int mana)
        {
            this.Damage = damage;
            this.Protection = protection;
            this.Agility = agility;
            this.Luck = luck;
            this.Health = health;
            this.Mana = mana;
        }
    }
}
