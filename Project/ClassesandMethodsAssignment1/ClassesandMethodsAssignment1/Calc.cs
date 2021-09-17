using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesandMethodsAssignment1
{
    class Calc
    {
        public int add(int num1, int num2)

        {

            return num1 + num2;

        }

        public int add(double num1, double num2)

        {

            return Convert.ToInt32(num1 + num2);

        }
        public int Subtract(int num1, int num2)

        {

            return num1 - num2;

        }

        public int Multiple(string str)

        {

            int num = Convert.ToInt32(str);

            return num * 2;

        }
    }
}
