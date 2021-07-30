using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    public class Calc
    {
        public int add(int a,int b)
        {
            int c = a + b;
            return c;
        }
        public int add(float a, float b)
        {
            int c = (int)(a) +(int) b;
            return c;
        }
        public int add(String a, String b)
        {
            int c = Convert.ToInt32(a) + Convert.ToInt32(b);
            return c;
        }

    }
}
