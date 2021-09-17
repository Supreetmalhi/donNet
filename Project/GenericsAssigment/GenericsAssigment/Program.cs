
using System;
using System.Collections.Generic;

namespace GenericsAssigment
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            // Create a object Of Employee with String
            Employee<string> StringThings = new Employee<string>();
            List<string> strList= new List<string>() { "HEllo","World"};
            StringThings.ValueOfThings=strList;
            StringThings.PrintThingsValue();

            // Creating a object of Employee with int
            Employee<int> IntThings = new Employee<int>();
            List<int> intList = new List<int>() { 1,2};
            IntThings.ValueOfThings = intList;
            IntThings.PrintThingsValue();


        }
    }
}
