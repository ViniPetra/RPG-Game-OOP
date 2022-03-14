using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD
{
    internal class Mage : Hero
    {

        public Mage()
        {

        }

        public Mage(string name, int age, int level, Hero_Status status) : base(name, age, level, status)
        {

        }

        //Healing
        public void Heal(Hero hero) 
        {
            Random random = new Random(); //Instanciates random num
            int randomNum = random.Next(1, this.Status.Luck); //Generates radom num based on Luck
            double div = (1 + randomNum / 100);
            int healVal = ((int)div);
            hero.Status.Health += hero.Status.Health * healVal; //Heals life as % of current
            this.Status.Mana -= 10;
        }
    }
}