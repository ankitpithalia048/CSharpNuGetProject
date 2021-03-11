using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNuGetProject
{
    struct Student
    {
        public string Name;
        public string Class;
        public string Section;
        public string GetName()
        {
            return Name;
        }
        public string GetClass()
        {
            return Class;
        }
        public string GetSection()
        {
            return Section;
        }
    }
    static class IStudent
    {
        private static List<Student> student = new List<Student>();
        public static void AddStudent()
        {
            Console.WriteLine("Enter Name Of The Student");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Class ");
            string cls = Console.ReadLine();
            Console.WriteLine("Enter Section");
            string sec = Console.ReadLine();
            Student s = new Student();
            s.Name = name;
            s.Class = cls;
            s.Section = sec;
            student.Add(s);
        }

        public static List<Student> GetStudentList()
        {
            return student;
        }
    }
}
