using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Warrior hero = new Warrior("1", 10, 5, (new Hero_Status(55, 40, 10, 20, 175, 0)));

            Spider spider = new Spider(10, new Monster_Status(20, 5, 35, 10, 40, 0));

            int x = hero.Attack();
            Console.WriteLine("Attack value");
            Console.WriteLine(x);
            Console.WriteLine("Spider life pre");
            Console.WriteLine(spider.Status.Health);
            spider.ReceiveAttack(x);
            Console.WriteLine("spider life post");
            Console.WriteLine(spider.Status.Health);
            Console.WriteLine();

            x = hero.Attack();
            Console.WriteLine("Attack value");
            Console.WriteLine(x);
            Console.WriteLine("Spider life pre");
            Console.WriteLine(spider.Status.Health);
            spider.ReceiveAttack(x);
            Console.WriteLine("spider life post");
            Console.WriteLine(spider.Status.Health);
            Console.WriteLine();

            x = hero.Attack();
            Console.WriteLine("Attack value");
            Console.WriteLine(x);
            Console.WriteLine("Spider life pre");
            Console.WriteLine(spider.Status.Health);
            spider.ReceiveAttack(x);
            Console.WriteLine("spider life post");
            Console.WriteLine(spider.Status.Health);
        }
    }
}
