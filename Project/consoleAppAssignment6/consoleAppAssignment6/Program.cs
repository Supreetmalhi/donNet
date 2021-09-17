using System;
using System.Collections.Generic;
using System.Linq;

namespace consoleAppAssignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>() { "Joe","Jeo","jio","jomy","jony","Joe" };
            HashSet<string> hash = new HashSet<string>();
            foreach(string item in list)
            {
                if (hash.Contains(item))
                {
                    Console.WriteLine(item+" Is already appread in the list");
                }
                else
                {
                    hash.Add(item);
                    Console.WriteLine(item + " Is not present in the list");

                }
            }
        }
    }
}
