using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voorbeelden
{
    public class Select
    {
        static IList<Cursus> c = new List<Cursus>() {
            new Cursus("programmeren 1", 6),
            new Cursus("web 1",3),
            new Cursus("Databanken",4),
            new Cursus("Labo",3)};
        IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 18,cursussen={c[0]} } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 15,cursussen={c[1],c[2]} } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25,cursussen={c[0],c[3],c[1]} } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20,cursussen={c[0],c[1]} } ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }};

        public void select1()
        {
            Console.WriteLine("select 1 ------");
            var sel = studentList.Select(s => s.StudentName);
            foreach (var x in sel) Console.WriteLine(x);
            Console.WriteLine("---------------");
        }
        public void select2()
        {
            Console.WriteLine("select 2 ------");
            var sel = studentList.Select(s => new { naam = s.StudentName, aantalCursussen = s.cursussen.Count() });
            foreach (var x in sel) Console.WriteLine(x);
            Console.WriteLine("---------------");
        }
        public void select3()
        {
            Console.WriteLine("select 3 ------");
            var sel = studentList.SelectMany(s => s.cursussen);
            foreach (var x in sel) Console.WriteLine(x);
            Console.WriteLine("---------------");
        }
        public void select4()
        {
            Console.WriteLine("select 4 ------");
            var sel = studentList.SelectMany(s => s.cursussen).Distinct();
            foreach (var x in sel) Console.WriteLine(x);
            Console.WriteLine("---------------");
        }
        public void select5()
        {
            Console.WriteLine("select 5 ------");
            var sel = studentList.SelectMany(s => s.cursussen,
                (student, program) => new
                {
                    studentName = student.StudentName,
                    cursusName = program
                });
            foreach (var x in sel) Console.WriteLine(x);
            Console.WriteLine("---------------");
        }
    }
}
