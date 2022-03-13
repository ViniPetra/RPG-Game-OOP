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
        }
    }
}
