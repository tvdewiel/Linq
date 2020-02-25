using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voorbeelden
{
    public class Element
    {
        IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }};

        public void ElementAt()
        {
            Console.WriteLine(studentList.ElementAt(1));
            Console.WriteLine(studentList.ElementAt(4));
            Console.WriteLine(studentList.ElementAtOrDefault(1));
            Console.WriteLine(studentList.ElementAtOrDefault(7));
            //Console.WriteLine(studentList.ElementAt(7));
        }
        public void FirstLast()
        {
            Console.WriteLine(studentList.First());
            Console.WriteLine(studentList.First(x => x.Age > 20));
            Console.WriteLine(studentList.Last());
            Console.WriteLine(studentList.Last(x => x.Age > 19));

        }
        public void Take()
        {
            foreach(var x in studentList.Take(2))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-------------------");
            foreach (var x in studentList.TakeWhile(s=>s.StudentName.Length>3))
            {
                Console.WriteLine(x);
            }
        }
        public void Skip()
        {
            foreach (var x in studentList.Skip(1))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-------------------");
            foreach (var x in studentList.SkipWhile(s => s.Age<20))
            {
                Console.WriteLine(x);
            }
        }
    }
}
