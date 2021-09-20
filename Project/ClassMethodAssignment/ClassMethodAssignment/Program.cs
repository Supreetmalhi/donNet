using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            Console.WriteLine("Enter the number:");
            string number = Console.ReadLine();
            c.add(Int32.Parse(number));
            Console.WriteLine("Divide by 2:- ");
            Console.WriteLine(c.divide(Int32.Parse(number)));

            Console.WriteLine("Using the out parameter");
            StaticClass.GetString(out string x);
            Console.WriteLine(x);


            StaticClass.GetString(2, out string y);
            Console.WriteLine(y);
        }
    }
   
}
