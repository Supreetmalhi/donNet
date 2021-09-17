using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAssigment
{
    public class Employee<T>
    {
        private List<T> Things;
        public List<T> ValueOfThings
        {
            get
            {
                return this.Things;
            }
            set
            {
                this.Things = value;
            }
        }
 

        public void PrintThingsValue()
        {
            foreach(T Item in this.Things)
            {
                Console.WriteLine(Item);
            }
        }
    }
}
