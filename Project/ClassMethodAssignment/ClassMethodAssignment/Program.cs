﻿using System;

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
            Console.WriteLine("Using the out parameter");
            c.getString(out string x);
            Console.WriteLine(x);

        }
    }
   
}
