
using System;

namespace classMethodAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine("please Enter  number");
            int firstnumber= Convert.ToInt32(Console.ReadLine());
            int secondNumber=0;
            calc.Add(a:firstnumber, b: secondNumber);
            
        }
    }
    class Calc
    {
        public void Add(int a,int b)
        {
            int c = a + a;
            Console.WriteLine(b);
        }
    }
}
