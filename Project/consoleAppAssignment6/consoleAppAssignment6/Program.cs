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

            IEnumerable<String> duplicates = list.GroupBy(x => x)
                                            .Where(g => g.Count() > 1)
                                            .Select(x => x.Key);

            Console.WriteLine("Duplicate elements are: " + String.Join(",", duplicates));
        }
    }
    }
