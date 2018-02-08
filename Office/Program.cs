using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class Program
    {
        static void Main(string[] args)
        {
            bool entrance = true;
            while (entrance == true)
            {
                Console.WriteLine("Greetings!\nWelcome to the office space!\n\nWho were you exactly? Don't quite remember.");
                Console.WriteLine("\n1) Student\n2) A boss\n3) Developer\n4) Janitor\n5) Electronics cleaner\n6) Database handler");
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        Console.Clear();
                        var person = new YoungDev();
                        person.Enter();

                        break;
                    case 2:
                        Console.Clear();
                        var person2 = new Boss();
                        person2.Enter();
                        break;
                    case 3:
                        Console.Clear();
                        var person3 = new Developer();
                        person3.Enter();
                        break;
                    case 4:
                        Console.Clear();
                        var person4 = new Janitor();
                        person4.Enter();
                        break;
                    case 5:
                        Console.Clear();
                        var person5 = new ElectronicCleaner();
                        person5.Enter();
                        break;
                    case 6:
                        Console.Clear();
                        var person6 = new DatabaseHandler();
                        person6.Enter();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid option");
                        break;
                }

            }
        }
    }
}
