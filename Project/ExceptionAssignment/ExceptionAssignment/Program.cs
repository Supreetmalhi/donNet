using System;
using System.Collections.Generic;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            number.Add(12);
            number.Add(13);

            number.Add(14);

            number.Add(15);

            number.Add(16);

            number.Add(17);

            number.Add(18);
            number.Add(19);

            number.Add(20);

            number.Add(21);

            number.Add(22);

            number.Add(23);

            Console.WriteLine("pLease Enter number");

       
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                foreach (int item in number)
                {
                    Console.WriteLine(item / num);
                }
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("User ENter 0 Please Enter Vaid Number");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("plese enter String");
            }
        }
    }
}
