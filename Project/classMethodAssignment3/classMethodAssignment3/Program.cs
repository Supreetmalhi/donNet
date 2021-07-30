
using System;

namespace classMethodAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine("please Enter  number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b=0;
            calc.Add(a, b);
        }
    }
    class Calc
    {
        public void Add(int a,int b)
        {
            b = a + a;
            Console.WriteLine(b);
        }
    }
}
