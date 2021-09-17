using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodAssignment
{
   public class Calc
    {
        public void add(int a)
        {
            int c = a /2;
            Console.WriteLine(c);
        }
        public void add(float a, float b)
        {
            int c = (int)(a) + (int)b;
            Console.WriteLine(c);
        }
        public void add(String a, String b)
        {
            int c = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine(c);
        }

    }
}
