using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voorbeelden
{
    public class Group
    {
        IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "Bill", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
        new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 } };
        public void group1()
        {
            Console.WriteLine("group 1--------");
            var groupedResult = studentList.GroupBy(s => s.Age);
            Console.WriteLine(groupedResult.GetType());
            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key);  //Each group has a key 

                foreach (Student s in ageGroup)  //Each group has a inner collection  
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
            Console.WriteLine("---------------");
        }
        public void group2()
        {
            Console.WriteLine("group 2--------");
            var groupedResult = studentList.ToLookup(s => s.Age);
            Console.WriteLine(groupedResult.GetType());
            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key);  //Each group has a key 

                foreach (Student s in ageGroup)  //Each group has a inner collection  
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
            Console.WriteLine("---------------");
        }
        public void group3()
        {
            Console.WriteLine("group 3--------");
            var groupedResult = studentList.GroupBy(s => new { s.Age, s.StudentName });
            Console.WriteLine(groupedResult.GetType());
            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key);  //Each group has a key 

                foreach (Student s in ageGroup)  //Each group has a inner collection  
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
            Console.WriteLine("---------------");
        }
    }
}
