using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArraysDemo
    {
        public static void Main()
        {
            int[] num = new int[10];
            Console.WriteLine("Enter elememts");

            for (int i = 0; i < 10;)
            {
                num[i] = Byte.Parse(Console.ReadLine());
                i++;
            }
            //Console.WriteLine("ELements are");
            for (int i = 0; i < 10; i++)
            {
                num[i] = 10 ;
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("ELements are");
            foreach (int i in num)
            {
                //i = 20;
                Console.WriteLine(i);
            }
        }



    }
        }
     