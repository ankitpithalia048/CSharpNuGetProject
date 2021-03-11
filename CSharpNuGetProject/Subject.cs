using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNuGetProject
{
        struct Subject
        {
            public string Name;
            public string SubjectCode;
            public string GetName()
            {
                return Name;
            }
            public string GetSubjectCode()
            {
                return SubjectCode;
            }
        }
    static class ISubject
    {
        private static List<Subject> subject = new List<Subject>();
        public static void AddSubject()
        {
            Console.WriteLine("Enter Name Of The Subject");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Subject Code");
            string subc = Console.ReadLine();
            Subject s = new Subject();
            s.Name = name;
            s.SubjectCode = subc;
            subject.Add(s);
        }
        public static List<Subject> GetSubjectList()
        {
            return subject;
        }
    }

}
