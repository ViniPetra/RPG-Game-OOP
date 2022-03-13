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