using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNuGetProject
{
    struct Teacher
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
    static class Iteacher
    {
        private static List<Teacher> teacher = new List<Teacher>();
        public static void AddTeacher()
        {
            Console.WriteLine("Enter Name Of The Teacher");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Class ");
            string cls = Console.ReadLine();
            Console.WriteLine("Enter Section");
            string sec = Console.ReadLine();
            Teacher t = new Teacher();
            t.Name = name;
            t.Class = cls;
            t.Section = sec;
            teacher.Add(t);
        }
        public static List<Teacher> GetTeacherList()
        {
            return teacher;
        }
    }
}
