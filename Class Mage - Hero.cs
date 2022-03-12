using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD
{
    internal class Mage : Hero
    {
        //Atributes

        //Getters and Setters

        //Empty constructor
        public Mage()
        {

        }

        //Constructor
        public Mage(string name, int age, int level, Hero_Status status) : base(name, age, level, status)
        {

        }

        //FUNCTIONS 

        //Defense
        public int Defense()
        {
            Random random = new Random(); //Instanciates random num
            int randomNum = random.Next(this.Status.Luck); //Generates radom num based on Luck
            double div = (this.Status.Protection + this.Status.Agility) * (1 + randomNum / 100);
            int defenseVal = ((int)div); // Gets defense value
            return defenseVal;
        }

        //Gets attacked
        public int ReceiveAttack(int attackStrengh)
        {
            int defense = Defense();
            int lifeReduction = defense - attackStrengh;
            return lifeReduction;
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