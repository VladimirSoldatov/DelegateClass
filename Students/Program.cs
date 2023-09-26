using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace SimpleProject
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
    class Program
    {
        static void FullName(Student student)
        {
            WriteLine($" {student.LastName}\t{student.FirstName}");
        }
        static string ToFullName(Student student)
        {
            return ($" {student.LastName}\t{student.FirstName}");
        }
        static bool OnlySpring(Student student)
        {
            return student.BirthDate.Month >=
            3 && student.BirthDate.Month <= 5;
        }
        static void Main(string[] args)
        {
            List<Student> group = new List<Student> {
                new Student {
                FirstName = "John",
                LastName = "Miller",
                BirthDate = new DateTime(1997,3,12)
                },
                new Student {
                FirstName = "Candice",
                LastName = "Leman",
                BirthDate = new DateTime(1998,7,22)
                },
                new Student {
                FirstName = "Joey",
                LastName = "Finch",
                BirthDate = new DateTime(1996,11,30)
                },
                new Student {
                FirstName = "Nicole",
                LastName = "Taylor",
                BirthDate = new DateTime(1996,5,10)
                }
            };
            WriteLine("List of students:");
            group.ForEach(FullName);

            WriteLine("List of students:");
            IEnumerable<Student> students = group.Where(s=>ToFullName(s) == " Miller\tJohn");
            foreach (var item in students)
            {
                WriteLine(ToFullName(item));
            }
            var students1 = group.Any(OnlySpring);
        }
    }
    
}