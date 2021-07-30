
using System;

namespace GenericsAssigment
{
    class Program
    {
        public class Employee<T>
        {



            // private data members 

            private T data;



            // using properties 

            public T value

            {



                // using accessors 

                get

                {

                    return this.data;

                }

                set

                {

                    this.data = value;

                }

            }
        }
        static void Main(string[] args)
        {
            Employee<string> name = new Employee<string>();

            name.value = "Joe";





            Employee<float> version = new Employee<float>();

            version.value = 5.0F;



            

            Console.WriteLine(name.value);



            

            Console.WriteLine(version.value);

        }
    }
}
