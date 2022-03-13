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

        public Goblin(int level, Monster_Status status) : base(level, status)
        {

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
            if (IsDead() == true)
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
            return lifeReduction;
        }
        public int Attack()
        {
            if (IsDead() == true)
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
        public bool IsDead()
        {
            if (this.Status.Health < 0)
            {
                Console.WriteLine("Can't do, object is dead");
                return true;
            }
            else return false;
        }
    }
}
