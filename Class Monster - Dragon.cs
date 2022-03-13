using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD
{
    internal class Dragon : Monster
    {
        //Empty constructor
        public Dragon()
        {

        }

        //Constructor
        public Dragon(int level, Monster_Status status) : base(level, status)
        {

        }

        public int Defense()
        {
            Random random = new Random(); //Instanciates random num
            int randomNum = random.Next(1, this.Status.Luck); //Generates radom num based on Luck
            double randDiv = (this.Status.Protection + this.Status.Agility) * (1 + randomNum / 100);
            int defenseVal = ((int)randDiv); // Gets defense value
            return defenseVal;
        }

        public int ReceiveAttack(int attackStrengh)
        {
            int defense = Defense();
            int lifeReduction = defense - attackStrengh;
            return lifeReduction;
        }
    }
}
