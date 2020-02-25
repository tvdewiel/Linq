using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeelden
{
    public class Student
    {
        public List<Cursus> cursussen { get; set; }
        public Student()
        {
            cursussen = new List<Cursus>();
        }

        public Student(int studentID, string studentName, int age)
        {
            StudentID = studentID;
            StudentName = studentName;
            Age = age;
            cursussen = new List<Cursus>();
        }

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{StudentID},{StudentName},{Age}";
        }
    }
}
