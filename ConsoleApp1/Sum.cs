using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Sum
    {
        //    int x;
        //    int y = 20;
        //    int[] num = new [] { 1, 2, 3, 4, 5, };
        int[,] matrix = new int[3, 3];

        int[,] arr = new[,]
        { { 1, 2, 3 },
            {2,3,4},
            {2,3,4} };



        // Sum of 10 numbers
        public static void Main()

        {
            char c = 'y';
            int num;
            int sum = 0;
            while (c == 'y')
            {
                Console.WriteLine("ENter Num");
                num = SByte.Parse(Console.ReadLine());
                if (num < 0) continue;
                if (num == 100) break;
                sum += num;
                Console.WriteLine("Continue");
                c = Convert.ToChar(Console.ReadLine());

            }
            Console.WriteLine("SUm is {0}", sum);
                }
    }
    }