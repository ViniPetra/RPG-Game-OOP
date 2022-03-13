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
            
            bool Running = true;

            Random random = new Random();
            
            int GenerateRandomNum(int min, int max)
            {
                int randomNum = random.Next(min, max);
                return randomNum;
            }

            Warrior warrior = new Warrior("warrior", GenerateRandomNum(1, 90), GenerateRandomNum(1, 100), new Hero_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));
            Archer archer = new Archer("archer", GenerateRandomNum(1, 90), GenerateRandomNum(1, 100), new Hero_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));
            Mage mage = new Mage("mage", GenerateRandomNum(1, 90), GenerateRandomNum(1, 100), new Hero_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), GenerateRandomNum(10, 100)));

            Spider spider = new Spider(GenerateRandomNum(1, 100), new Monster_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));
            Goblin goblin = new Goblin(GenerateRandomNum(1, 100), new Monster_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));


            warrior.PrintStats();
            archer.PrintStats();
            mage.PrintStats();
            spider.PrintStats();
            goblin.PrintStats();

            while (Running)
            {
                string optS, targetS, heroS;
                int opt, target, hero, attackVal;

                if(spider.Status.Health <= 0 && goblin.Status.Health <= 0)
                {
                    Console.WriteLine("You win");
                    Running = false;
                    return 0;
                }
                
                Console.WriteLine("Choose Hero:\n1 - Warrior\n2 - Archer\n3 - Mage");
                heroS = Console.ReadLine();
                hero = Int32.Parse(heroS);

                switch (hero)
                {
                    case 1:
                        Console.WriteLine("Choose the action:\n1 - Attack\n2 - See stats");
                        optS = Console.ReadLine();
                        opt = Int32.Parse(optS);

                        switch (opt)
                        {
                            case 1:
                                Console.WriteLine("Choose the target:\n1 - Spider\n2 - Goblin");
                                targetS = Console.ReadLine();
                                target = Int32.Parse(targetS);

                                switch (target)
                                {
                                    case 1:
                                        attackVal = warrior.Attack();
                                        spider.ReceiveAttack(attackVal);
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(spider.Status.Health);
                                        break;
                                    case 2:
                                        attackVal = warrior.Attack();
                                        goblin.ReceiveAttack(attackVal);
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(goblin.Status.Health);
                                        break;
                                }
                                break;
                            case 2:
                                warrior.PrintStats();
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Choose the action:\n1 - Attack\n2 - See stats");
                        optS = Console.ReadLine();
                        opt = Int32.Parse(optS);

                        switch (opt)
                        {
                            case 1:
                                Console.WriteLine("Choose the target:\n1 - Spider\n2 - Goblin");
                                targetS = Console.ReadLine();
                                target = Int32.Parse(targetS);

                                switch (target)
                                {
                                    case 1:
                                        attackVal = archer.Attack();
                                        spider.ReceiveAttack(attackVal);
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(spider.Status.Health);
                                        break;
                                    case 2:
                                        attackVal = archer.Attack();
                                        goblin.ReceiveAttack(attackVal);
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(goblin.Status.Health);
                                        break;
                                }
                                break;
                            case 2:
                                archer.PrintStats();
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Choose the action:\n1 - Attack\n2 - Heal\n3 - See stats");
                        optS = Console.ReadLine();
                        opt = Int32.Parse(optS);

                        switch (opt)
                        {
                            case 1:
                                Console.WriteLine("Choose the target:\n1 - Spider\n2 - Goblin");
                                targetS = Console.ReadLine();
                                target = Int32.Parse(targetS);

                                switch (target)
                                {
                                    case 1:
                                        attackVal = mage.Attack();
                                        spider.ReceiveAttack(attackVal);
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(spider.Status.Health);
                                        break;
                                    case 2:
                                        attackVal = mage.Attack();
                                        goblin.ReceiveAttack(attackVal);
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(goblin.Status.Health);
                                        break;
                                }
                                break;
                            case 2:
                                Console.WriteLine("Choose the target:\n1 - Warrior\n2 - Archer");
                                targetS = Console.ReadLine();
                                target = Int32.Parse(targetS);
                                switch (target)
                                {
                                    case 1:
                                        mage.Heal(warrior);
                                        break;
                                    case 2:
                                        mage.Heal(archer);
                                        break;
                                }
                                break;

                            case 3:
                                mage.PrintStats();
                                hero = 1;
                                break;
                        }
                        break;
                }
            }
            return 0;
        }
    }
}
