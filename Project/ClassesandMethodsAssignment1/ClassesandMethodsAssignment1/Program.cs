using System;

namespace ClassesandMethodsAssignment1

{

    class Program

    {
        static void Main(string[] args)

        {

            Calc c = new Calc();

            Console.WriteLine("Integer Function is Called");

            Console.WriteLine(c.add(10, 20));

            Console.WriteLine("Decimal Function is Called");

            Console.WriteLine(c.add(10.1, 20.11));

            Console.WriteLine("String Function is Called");

            Console.WriteLine(c.Multiple("100"));

        }

    }

}
