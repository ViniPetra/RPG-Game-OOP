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

            Hero[] allHeroes = new Hero[9];
            for (int i = 0; i < allHeroes.Length; i++)
            {
                if (i == 0 || i == 3 || i == 6)
                {
                    allHeroes[i] = new Warrior("Warrior", GenerateRandomNum(1, 90), GenerateRandomNum(1, 100), new Hero_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));
                } else if (i == 1 || i == 4 || i == 7)
                {
                    allHeroes[i] = new Archer("Archer", GenerateRandomNum(1, 90), GenerateRandomNum(1, 100), new Hero_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));
                } else
                {
                    allHeroes[i] = new Mage("Mage", GenerateRandomNum(1, 90), GenerateRandomNum(1, 100), new Hero_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), GenerateRandomNum(10, 100)));
                }
            }
            Hero[] heroes = new Hero[3];
            for (int i = 0; i < heroes.Length; i++)
            {
                heroes[i] = allHeroes[GenerateRandomNum(0, 8)];
                Console.WriteLine("Posição {0}: {1}", i, heroes[i].HeroName);
                heroes[i].PrintStats();
            }

            Monster[] allMonsters = new Monster[9];
            for (int i = 0; i < allMonsters.Length; i++)
            {
                if (i == 0 || i == 3 || i == 6)
                {
                    allMonsters[i] = new Spider("Spider", GenerateRandomNum(1, 100), new Monster_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));
                }
                else if (i == 1 || i == 4 || i == 7)
                {
                    allMonsters[i] = new Goblin("Goblin", GenerateRandomNum(1, 100), new Monster_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));
                }
                else
                {
                    allMonsters[i] = new Dragon("Dragon", GenerateRandomNum(1, 100), new Monster_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));
                }
            }

            Monster[] monsters = new Monster[2];
            for (int i = 0; i < monsters.Length; i++)
            {
                monsters[i] = allMonsters[GenerateRandomNum(0, 8)];
                Console.WriteLine("Monstro {0}: {1}", i, monsters[i].Name);
                monsters[i].PrintStats();
            }

            Warrior warrior = new Warrior("warrior", GenerateRandomNum(1, 90), GenerateRandomNum(1, 100), new Hero_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));
            Archer archer = new Archer("archer", GenerateRandomNum(1, 90), GenerateRandomNum(1, 100), new Hero_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));
            Mage mage = new Mage("mage", GenerateRandomNum(1, 90), GenerateRandomNum(1, 100), new Hero_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), GenerateRandomNum(10, 100)));

            Spider spider = new Spider("Spider", GenerateRandomNum(1, 100), new Monster_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));
            Goblin goblin = new Goblin("Goblin", GenerateRandomNum(1, 100), new Monster_Status(GenerateRandomNum(20, 100), GenerateRandomNum(20, 100), GenerateRandomNum(10, 100), GenerateRandomNum(1, 100), GenerateRandomNum(30, 100), 0));

            while (Running)
            {
                string optS, targetS, heroS;
                int opt, target, hero, monsterTurn;
                
                //Player's turn
                Console.WriteLine("Choose Hero:\n1 - {0}\n2 - {1}\n3 - {2}", heroes[0].HeroName ,heroes[1].HeroName, heroes[2].HeroName);
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
                                Console.WriteLine("Choose the target:\n1 - {0}\n2 - {1}", monsters[0].Name);
                                targetS = Console.ReadLine();
                                target = Int32.Parse(targetS);

                                switch (target)
                                {
                                    case 1:
                                        spider.ReceiveAttack(warrior.Attack());
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(spider.Status.Health);
                                        break;
                                    case 2:
                                        goblin.ReceiveAttack(warrior.Attack());
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
                                        spider.ReceiveAttack(archer.Attack());
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(spider.Status.Health);
                                        break;
                                    case 2:
                                        goblin.ReceiveAttack(archer.Attack());
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
                                        spider.ReceiveAttack(mage.Attack());
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(spider.Status.Health);
                                        break;
                                    case 2:
                                        goblin.ReceiveAttack(mage.Attack());
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
                                break;
                        }
                        break;
                }

                //Monster's turn

                if (spider.IsDead() || goblin.IsDead() == false)
                {
                    monsterTurn = GenerateRandomNum(1, 3);

                    switch (monsterTurn)
                    {
                        case 1:
                            if (warrior.IsDead() == false)
                            {
                                warrior.ReceiveAttack(goblin.Attack());
                                Console.WriteLine("Goblin has attacked Warrior");
                                Console.WriteLine("Warrior's health:");
                                Console.WriteLine(warrior.Status.Health);
                            }
                            break;

                        case 2:
                            if (archer.IsDead() == false)
                            {
                                archer.ReceiveAttack(goblin.Attack());
                                Console.WriteLine("Goblin has attacked Archer");
                                Console.WriteLine("Archer's health:");
                                Console.WriteLine(archer.Status.Health);
                            }
                            break;

                        case 3:
                            if (mage.IsDead() == false)
                            {
                                mage.ReceiveAttack(goblin.Attack());
                                Console.WriteLine("Goblin has attacked Mage");
                                Console.WriteLine("Mage's health:");
                                Console.WriteLine(mage.Status.Health);
                            }
                            break;
                    }
                }
                else if (spider.IsDead() == false || goblin.IsDead())
                {
                    monsterTurn = GenerateRandomNum(1, 3);
                    switch (monsterTurn)
                    {
                        case 1:
                            if (warrior.IsDead() == false)
                            {
                                warrior.ReceiveAttack(spider.Attack());
                                Console.WriteLine("Spider has attacked Warrior");
                                Console.WriteLine("Warrior's health:");
                                Console.WriteLine(warrior.Status.Health);
                            }
                            break;

                        case 2:
                            if (archer.IsDead() == false)
                            {
                                archer.ReceiveAttack(spider.Attack());
                                Console.WriteLine("Spider has attacked Archer");
                                Console.WriteLine("Acher's health:");
                                Console.WriteLine(archer.Status.Health);
                            } 
                            break;

                        case 3:
                            if (mage.IsDead() == false)
                            {
                                mage.ReceiveAttack(spider.Attack());
                                Console.WriteLine("Spider has attacked Mage");
                                Console.WriteLine("Mage's health:");
                                Console.WriteLine(mage.Status.Health);
                            }
                            break;
                    }
                }

                //Check who won
                if (spider.IsDead() && goblin.IsDead())
                {
                    Console.WriteLine("You win");
                    Running = false;
                    return 0;
                }
                if (warrior.IsDead()  && archer.IsDead() && mage.IsDead())
                {
                    Console.WriteLine("You lose");
                    Running = false;
                    return 0;
                }
            }
            return 0;
        }
    }
}
            
