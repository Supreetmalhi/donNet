using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of student:-");
            string name = Console.ReadLine();
            using (var ctx = new StudentContext())
            {
                
                var student = new Student() { StudentName = name };

                ctx.Students.Add(student);
                ctx.SaveChanges();
                Console.WriteLine("insert");
            }
            Console.ReadLine();
        }
    }
}
