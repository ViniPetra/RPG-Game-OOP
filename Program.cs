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
                                Console.WriteLine("Choose the target:\n1 - {0}\n2 - {1}", monsters[0].Name, monsters[1].Name);
                                targetS = Console.ReadLine();
                                target = Int32.Parse(targetS);

                                switch (target)
                                {
                                    case 1:
                                        monsters[0].ReceiveAttack(heroes[0].Attack());
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(monsters[0].Status.Health);
                                        break;
                                    case 2:
                                        monsters[1].ReceiveAttack(heroes[0].Attack());
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(monsters[1].Status.Health);
                                        break;
                                }
                                break;
                            case 2:
                                heroes[0].PrintStats();
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
                                Console.WriteLine("Choose the target:\n1 - {0}\n2 - {1}", monsters[0].Name, monsters[1].Name);
                                targetS = Console.ReadLine();
                                target = Int32.Parse(targetS);

                                switch (target)
                                {
                                    case 1:
                                        monsters[0].ReceiveAttack(heroes[1].Attack());
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(monsters[0].Status.Health);
                                        break;
                                    case 2:
                                        monsters[1].ReceiveAttack(heroes[1].Attack());
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(monsters[1].Status.Health);
                                        break;
                                }
                                break;
                            case 2:
                                heroes[1].PrintStats();
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Choose the action:\n1 - Attack\n2 - See stats");
                        optS = Console.ReadLine();
                        opt = Int32.Parse(optS);

                        switch (opt)
                        {
                            case 1:
                                Console.WriteLine("Choose the target:\n1 - {0}\n2 - {1}", monsters[0].Name, monsters[1].Name);
                                targetS = Console.ReadLine();
                                target = Int32.Parse(targetS);

                                switch (target)
                                {
                                    case 1:
                                        monsters[0].ReceiveAttack(heroes[2].Attack());
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(monsters[0].Status.Health);
                                        break;
                                    case 2:
                                        monsters[1].ReceiveAttack(heroes[2].Attack());
                                        Console.WriteLine("Target's health:");
                                        Console.WriteLine(monsters[1].Status.Health);
                                        break;
                                }
                                break;
                                /*
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
                                */

                            case 2:
                                heroes[2].PrintStats();
                                break;
                        }
                        break;
                }

                //Monster's turn

                if (monsters[0].IsDead() || monsters[1].IsDead() == false)
                {
                    monsterTurn = GenerateRandomNum(1, 3);

                    switch (monsterTurn)
                    {
                        case 1:
                            if (heroes[0].IsDead() == false)
                            {
                                heroes[0].ReceiveAttack(monsters[1].Attack());
                                Console.WriteLine("{0} has attacked {1}", monsters[1].Name, heroes[0].HeroName);
                                Console.WriteLine("{0}'s health: {1}", heroes[0].HeroName, heroes[0].Status.Health);
                            }
                            break;

                        case 2:
                            if (heroes[1].IsDead() == false)
                            {
                                heroes[1].ReceiveAttack(monsters[1].Attack());
                                Console.WriteLine("{0} has attacked {1}", monsters[1].Name, heroes[1].HeroName);
                                Console.WriteLine("{0}'s health: {1}", heroes[1].HeroName, heroes[1].Status.Health);
                            }
                            break;

                        case 3:
                            if (heroes[2].IsDead() == false)
                            {
                                heroes[2].ReceiveAttack(monsters[1].Attack());
                                Console.WriteLine("{0} has attacked {1}", monsters[1].Name, heroes[2].HeroName);
                                Console.WriteLine("{0}'s health: {1}", heroes[2].HeroName, heroes[2].Status.Health);
                            }
                            break;
                    }
                }
                else if (monsters[0].IsDead() == false || monsters[1].IsDead())
                {
                    monsterTurn = GenerateRandomNum(1, 3);
                    switch (monsterTurn)
                    {
                        case 1:
                            if (heroes[0].IsDead() == false)
                            {
                                heroes[0].ReceiveAttack(monsters[0].Attack());
                                Console.WriteLine("{0} has attacked {1}", monsters[0].Name, heroes[0].HeroName);
                                Console.WriteLine("{0}'s health: {1}", heroes[0].HeroName, heroes[0].Status.Health);
                            }
                            break;

                        case 2:
                            if (heroes[1].IsDead() == false)
                            {
                                heroes[0].ReceiveAttack(monsters[0].Attack());
                                Console.WriteLine("{0} has attacked {1}", monsters[0].Name, heroes[1].HeroName);
                                Console.WriteLine("{0}'s health: {1}", heroes[1].HeroName, heroes[1].Status.Health);
                            } 
                            break;

                        case 3:
                            if (heroes[2].IsDead() == false)
                            {
                                heroes[0].ReceiveAttack(monsters[0].Attack());
                                Console.WriteLine("{0} has attacked {1}", monsters[0].Name, heroes[2].HeroName);
                                Console.WriteLine("{0}'s health: {1}", heroes[2].HeroName, heroes[2].Status.Health);
                            }
                            break;
                    }
                }

                //Check who won
                if (monsters[0].IsDead() && monsters[2].IsDead())
                {
                    Console.WriteLine("You win");
                    Running = false;
                    return 0;
                }
                if (heroes[0].IsDead()  && heroes[1].IsDead() && heroes[2].IsDead())
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
            
