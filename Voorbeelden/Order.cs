using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voorbeelden
{
    public class Order
    {
        IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 19 } ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }};

        public void order1()
        {
            Console.WriteLine("Order 1");
            var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);
            foreach(var x in studentsInAscOrder)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------");
        }
        public void order2()
        {
            Console.WriteLine("Order 2");
            var studentsInOrder = studentList.OrderByDescending(s => s.StudentName);
            foreach (var x in studentsInOrder)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------");
        }
        public void order3()
        {
            Console.WriteLine("Order 3");
            var studentsInOrder = studentList.OrderBy(s => s.Age).ThenBy(s=>s.StudentName);
            foreach (var x in studentsInOrder)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------");
        }
        public void order4()
        {
            Console.WriteLine("Order 4");
            var studentsInOrder = studentList.OrderBy(s => s.Age).ThenBy(s => s.StudentName).Reverse();
            foreach (var x in studentsInOrder)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------");
        }
    }
}
