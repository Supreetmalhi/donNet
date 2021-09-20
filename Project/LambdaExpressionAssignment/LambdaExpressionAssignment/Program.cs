using System;
using System.Collections.Generic;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Emp> emps = new List<Emp>();
            Emp emp = new Emp();
            emp.EmpId = 1;
            emp.firstName = "xyz";
            emp.LastName = "yzc";
            emps.Add(emp);
            Emp emp1 = new Emp();
            emp1.EmpId = 2;
            emp1.firstName = "xyz2";
            emp1.LastName = "yzc2";
            emps.Add(emp1);
            Emp emp2 = new Emp();
            emp2.EmpId = 3;
            emp2.firstName = "xyz3";
            emp2.LastName = "yzc3";
            emps.Add(emp2);
            Emp emp3 = new Emp();
            emp3.EmpId = 4;
            emp3.firstName = "Joe";
            emp3.LastName = "yzc4";
            emps.Add(emp3);
            Emp emp4 = new Emp();
            emp4.EmpId = 5;
            emp4.firstName = "xyz5";
            emp4.LastName = "yzc5";
            emps.Add(emp4);
            Emp emp5 = new Emp();
            emp5.EmpId = 6;
            emp5.firstName = "xyz6";
            emp5.LastName = "yzc6";
            emps.Add(emp5);
            Emp emp6 = new Emp();
            emp6.EmpId = 7;
            emp6.firstName = "Joe";
            emp6.LastName = "yzc7";
            emps.Add(emp6);
            Emp emp7 = new Emp();
            emp7.EmpId = 8;
            emp7.firstName = "Joe";
            emp7.LastName = "yzc";
            emps.Add(emp7);
            Emp emp8= new Emp();
            emp8.EmpId = 9;
            emp8.firstName = "Joe2";
            emp8.LastName = "yzc";
            emps.Add(emp8);

            Emp emp9 = new Emp();
            emp9.EmpId = 10;
            emp9.firstName = "Joe";
            emp9.LastName = "yz9";
            emps.Add(emp9);
            List<Emp> EmpData = new List<Emp>();
            Console.WriteLine("Using Foreach");
             foreach(Emp item in emps)
            {
                if(item.firstName=="Joe")
                {

                    Emp obj = new Emp();
                    obj.EmpId = item.EmpId;
                    obj.firstName = item.firstName;
                    obj.LastName = item.LastName;
                    EmpData.Add(obj);
               
                }    
            }


            Console.WriteLine("Using Lambda all the employees with name joe");


            List<Emp> EmpDataList = emps.FindAll(item => item.firstName.ToLower()=="joe");
            EmpDataList.ForEach(n => Console.WriteLine(n.EmpId + " " + n.firstName + " " + n.LastName));

            Console.WriteLine("List of Employees which have id greater than 5 using lambda expression");

            List<Emp> EmpGreaterThanFive = emps.FindAll(item=>item.EmpId>5);
            EmpGreaterThanFive.ForEach(n => Console.WriteLine(n.EmpId +" "+n.firstName+" "+ n.LastName));


            //foreach (Emp item in  emps.FindAll(item => item.firstName.Equals("Joe")))
            // {
            //      Emp obj = new Emp();
            //      obj.EmpId = item.EmpId;
            //      obj.firstName = item.firstName;
            //      obj.LastName = item.LastName;
            //      EmpDataList.Add(obj);

            //  }

            Console.ReadLine();
        }



    }
     public class Emp
    {
        public int EmpId { get; set; }
        public String firstName { get; set; }
        public String  LastName { get; set; }
    }
}
