using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   internal class Third
    {
    static int x = 10, y = 20;
        public static void Main()
        {
        Console.WriteLine(Add(x, y));
        Console.WriteLine(Subtract(x, y));
    }

      public static int Add(int x, int y)
    {

        return x + y;
    }

    public static int Subtract(int x, int y)
    {

        return x - y;
    }

}

 
