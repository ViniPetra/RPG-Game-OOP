using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD
{
    internal class Program
    {

        static int Main(string[] args)
        {
            Random random = new Random();
            
            int GenerateRandomNum(int min, int max)
            {
                int randomNum = random.Next(min, max);
                return randomNum;
            }

            bool Running = true;

            Warrior warrior = new Warrior("warrior", GenerateRandomNum(1, 90), GenerateRandomNum(1, 100), new Hero_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));
            Archer archer = new Archer("archer", GenerateRandomNum(1, 90), GenerateRandomNum(1, 100), new Hero_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));
            Mage mage = new Mage("mage", GenerateRandomNum(1, 90), GenerateRandomNum(1, 100), new Hero_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), GenerateRandomNum(10, 100)));

            Console.WriteLine(warrior.HeroName);
            Console.WriteLine(warrior.Age);
            Console.WriteLine(warrior.Level);
            Console.WriteLine(warrior.Status.Damage);
            Console.WriteLine(warrior.Status.Protection);
            Console.WriteLine(warrior.Status.Agility);
            Console.WriteLine(warrior.Status.Luck);
            Console.WriteLine(warrior.Status.Health);
            Console.WriteLine(warrior.Status.Mana);
            Console.WriteLine();

            Console.WriteLine(archer.HeroName);
            Console.WriteLine(archer.Age);
            Console.WriteLine(archer.Level);
            Console.WriteLine(archer.Status.Damage);
            Console.WriteLine(archer.Status.Protection);
            Console.WriteLine(archer.Status.Agility);
            Console.WriteLine(archer.Status.Luck);
            Console.WriteLine(archer.Status.Health);
            Console.WriteLine(archer.Status.Mana);
            Console.WriteLine();

            Console.WriteLine(mage.HeroName);
            Console.WriteLine(mage.Age);
            Console.WriteLine(mage.Level);
            Console.WriteLine(mage.Status.Damage);
            Console.WriteLine(mage.Status.Protection);
            Console.WriteLine(mage.Status.Agility);
            Console.WriteLine(mage.Status.Luck);
            Console.WriteLine(mage.Status.Health);
            Console.WriteLine(mage.Status.Mana);
            Console.WriteLine();

            return 0;
        }
    }
}
