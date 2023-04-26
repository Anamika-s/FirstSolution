using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Functions
    {
        public static void Main()
        {

            Console.WriteLine(Add("Deepak", "Sood"));
            Console.WriteLine(Add(10.7f, 19.0f, 8f));

            int add, subtract, product, remainder;
            Operations(20, 10, out add,
                out subtract,
                out product,
                out remainder);
            Console.WriteLine("Addition is {0}\n" +
                "Differnce is {1}\n" +
                "Product is {2}\n" +
                "Remander is{3}", add, subtract, product, remainder);

            Console.WriteLine("In is {0}", SI(12000, 10, 2));
            Console.WriteLine("In is {0}", SI(12000, 10));


            Console.WriteLine("Total sum is {0}", Total(1, 2));
            Console.WriteLine("Total sum is {0}", Total(1, 2, 2, 3, 4, 5, 6, 7, 7));


            int x = 200;
            Console.WriteLine("Value of x before calling change1 {0}", x);
            Change1(x);
            Console.WriteLine("Value of x after calling change1 {0}", x);
            Change2(ref x);
            Console.WriteLine("Value of x after calling change2 {0}", x);

        }

        // Method Overloading

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public static string Add(string str1, string str2)
        {
            //return str1 + " " + str2;
            return string.Concat(str1, ' ', str2);

        }

        public static float Add(float x, float y, float z)
        {
            return x + y + z;

        }

        // Output Parameters > A function cab return more than 1 value

        public static void Operations(
            int x, int y, out int add, out int subtract,
            out int product, out int remainder)
        {
            add = x + y;
            subtract = x - y;
            product = x * y;
            remainder = x % y;
        }

        // Default Paremeters

        public static float SI(int principal, int rate = 5, int time = 5)
        {
            return (principal * rate * time) / 100;
        }

        // Parameterized Array

        public static int Total(params int[] num)
        {
            int sum = 0;
            foreach (int x in num)
            {
                sum += x;
            }
            return sum;
        }

        public static void Change1(int x)
        {
            x = 100;
            Console.WriteLine("VAlue of x in Change1 {0}", x);

        }


        public static void Change2(ref int x)
        {
            x = 300;
            Console.WriteLine("VAlue of x in Change2 {0}", x);

        }
    }
}