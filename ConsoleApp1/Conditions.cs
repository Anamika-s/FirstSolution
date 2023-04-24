using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Conditions
    {
        public static void Main()
        {
            //int x, y;
            //Console.WriteLine("ENter no1 ");
            //x = Convert.ToByte(Console.ReadLine());
            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("EVen");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");

            //}

            //    int x, y, ch;
            //    Console.WriteLine("ENter no1");
            //    x = Byte.Parse(Console.ReadLine());
            //    Console.WriteLine("ENter no2");
            //    y = Byte.Parse(Console.ReadLine());

            //    Console.WriteLine("ENter choice");
            //    ch = Byte.Parse(Console.ReadLine());

            //    if (ch == 1 || ch==)
            //        Console.WriteLine(x + y);
            //    else if (ch == 2)
            //        Console.WriteLine(x - y);
            //    else if (ch == 3)
            //        Console.WriteLine(x * y);
            //    else if (ch == 4)
            //        Console.WriteLine(x / y);
            //    else
            //        Console.WriteLine("Invalid");

            //}

            int x, y;
            string ch;
            Console.WriteLine("ENter no1");
            x = Byte.Parse(Console.ReadLine());
            Console.WriteLine("ENter no2");
            y = Byte.Parse(Console.ReadLine());

            Console.WriteLine("ENter choice");
            ch = Console.ReadLine();

            switch (ch)
            {
                case "1":
                case "+":
                    Console.WriteLine(x + y);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

                case "2":
                case "-":
                    Console.WriteLine(x - y);
                    break;
                case "3":
                    Console.WriteLine(x * y);
                    break;
                case "4":
                    Console.WriteLine(x / y);
                    break;
                
            }

        }
    }
}
