using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32( Console.ReadLine());
            Random rnd = new Random();            

            switch (a)
            {
                case 1:
                    Console.WriteLine(rnd.Next(1, 99) + rnd.Next(1, 99)); //+
                    break;
                case 2:
                    Console.WriteLine(rnd.Next(1, 99) - rnd.Next(1, 99));
                    break;
                case 3:
                    Console.WriteLine(rnd.Next(1, 99) * rnd.Next(1, 99));
                    break;
                case 4:
                    Console.WriteLine(rnd.Next(1, 99) / rnd.Next(1, 99));
                    break;
               default:
                    Console.WriteLine("Error");
                    break;
            }

            //Задержка экрана
            Console.ReadKey();
        }
    }
}
