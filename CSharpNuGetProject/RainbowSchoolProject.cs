using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNuGetProject
{
    class RainbowSchoolProject
    {     
       public static void Do()
        {
            string input;
            do
            {
                Console.WriteLine("Please Select One option from below:");
                Console.WriteLine("1.Add Data\n2.List Data");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    AddData();
                }
                else
                {

                    ListData();
                }
                Console.WriteLine("\n\nWant to continue?Want to add or list data?(Type yes/no)");
                input = Console.ReadLine();

            } while (input.Equals("yes"));
        }
        private static void AddData()
        {
            string input;
            do
            {
                Console.WriteLine("\n====================== Adding Data =======================");
                Console.WriteLine("Please Select One option from below:");
                Console.WriteLine("1.Add Student \n2.Add Teacher\n3. Add Subject");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("=======Adding Student Data=========");
                    IStudent.AddStudent();
                }
                else if(option == 2)
                {
                    Console.WriteLine("=======Adding Teacher Data=========");
                    Iteacher.AddTeacher();

                }
                else
                {
                    Console.WriteLine("=======Adding Subject Data=========");
                    ISubject.AddSubject();
                }
                Console.WriteLine("\n\nWant to add more data?(Type yes/no)");
                input = Console.ReadLine();

            } while (input.Equals("yes"));
        }
        private static void ListData()
        {
            string input;
            do
            {
                Console.WriteLine("\n====================== Listing Data =======================");
                Console.WriteLine("Please Select One option from below:");
                Console.WriteLine("1.Display Student \n2.Display Teacher\n3. Display Subject");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("=======Students List=========");
                    List<Student> studs = IStudent.GetStudentList();
                    if (studs.Count == 0)
                        Console.WriteLine("No data");
                    else
                        foreach (Student s in studs)
                            Console.WriteLine("Name of the student: " + s.GetName() + "\t Class : " + s.GetClass()+ "\t Section: " + s.GetSection());
                }
                else if (option == 2)
                {
                    Console.WriteLine("=======Teacher List=========");
                    List<Teacher> teach = Iteacher.GetTeacherList();
                    if (teach.Count == 0)
                        Console.WriteLine("No data");
                    else
                        foreach (Teacher s in teach)
                            Console.WriteLine("Name of the teacher: " + s.GetName() + "\t Class : " + s.GetClass() + "\t Section: " + s.GetSection());

                }
                else
                {
                    Console.WriteLine("=======Subject List=========");
                    List<Subject> sub = ISubject.GetSubjectList();
                    if (sub.Count == 0)
                        Console.WriteLine("No data");
                    else
                        foreach (Subject s in sub)
                            Console.WriteLine("Name of the Subject: " + s.GetName() + "\t Subject Code : " + s.GetSubjectCode());

                }
                Console.WriteLine("\n\nWant to Diplay more record?(Type yes/no)");
                input = Console.ReadLine();

            } while (input.Equals("yes"));
        }
    }
}

