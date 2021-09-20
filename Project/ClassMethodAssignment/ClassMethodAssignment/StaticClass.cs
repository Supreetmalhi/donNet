using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodAssignment
{
    public static class StaticClass
    {
        static void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
       public static  void GetString(out string x)
        {
            int temp = 5;
            x = temp.ToString(); ;
        }

        public static void GetString(int y, out string x)
        {
           
             x= y.ToString(); ;
        }
    }
}
