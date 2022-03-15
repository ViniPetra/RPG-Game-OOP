﻿using System;
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

        public int Defence()
        {
            Random random = new Random(); //Instanciates random num
            int randomNum = random.Next(1, this.Status.Luck); //Generates radom num based on Luck
            int stats = (this.Status.Protection + this.Status.Agility);
            double val = stats * (1 + (randomNum / 100.0));
            int defenceVal = ((int)val); // Gets defence value
            return defenceVal;
        }

        public int ReceiveAttack(int attackStrengh)
        {
            if (IsDead(this) == true)
            {
                return -1;
            }

            int defence = Defence();
            int lifeReduction = defence - attackStrengh;
            if (lifeReduction < 0)
            {
                lifeReduction = lifeReduction * -1;
            }
            this.Status.Health = this.Status.Health - lifeReduction;
            if (this.Status.Health < 0)
            {
                Console.WriteLine("This monster is now dead");
            }
            return lifeReduction;
        }

        public int Attack()
        {
            if (IsDead(this) == true)
            {
                return -1;
            }

            Random random = new Random(); //Instanciates random num
            int randomNum = random.Next(1, this.Status.Luck); //Generates radom num based on Luck
            int stats = (this.Status.Damage + this.Status.Agility);
            double val = stats * (1 + (randomNum / 100.0));
            int attackVal = ((int)val); // Gets attack value
            return attackVal;
        }

        public bool IsDead(Monster monster)
        {
            if (this.Status.Health <= 0)
            {
                return true;
            }
            else return false;
        }

        public void PrintStats()
        {
            Console.WriteLine("Type: Monster");
            Console.WriteLine("Level: {0}", this.Level);
            Console.WriteLine("Damage: {0}", this.Status.Damage);
            Console.WriteLine("Protection: {0}", this.Status.Protection);
            Console.WriteLine("Agility: {0}", this.Status.Agility);
            Console.WriteLine("Luck: {0}", this.Status.Luck);
            Console.WriteLine("Health: {0}", this.Status.Health);
            Console.WriteLine("Mana: {0}", this.Status.Mana);
            Console.WriteLine();
        }
    }
}
