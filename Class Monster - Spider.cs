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
        public Spider(int level, Monster_Status status) : base(level, status)
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
            Random random = new Random(); //Instanciates random num
            int randomNum = random.Next(1, this.Status.Luck); //Generates radom num based on Luck
            int stats = (this.Status.Damage + this.Status.Agility);
            double val = stats * (1 + (randomNum / 100.0));
            int attackVal = ((int)val); // Gets attack value
            return attackVal;
        }
    }
}
