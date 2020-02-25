using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voorbeelden
{
    public class Filter
    {
        IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }};
        public void showFilter1()
        {
            Console.WriteLine("Filter 1");
            var filteredResult = studentList.Where(s => s.Age>18 && s.StudentName.Length>3);

            foreach (var std in filteredResult)
                Console.WriteLine(std.StudentName);
        }
        public void showFilter2()
        {
            Console.WriteLine("Filter 2");
            var filteredResult = studentList.Where((s, i) =>
            {
                if (i % 2 == 0) // if it is even element
                    return true;
                return false;
            });

            foreach (var std in filteredResult)
                Console.WriteLine(std.StudentName);
        }
    }
}
