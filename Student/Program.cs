using System.Collections;
using static System.Console;
namespace SimpleProject
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
      
    }
    class Program
    {
        static Hashtable group = new Hashtable
        {
            {
                new Student
                {
                    FirstName = "John",
                    LastName = "Miller"
                }
                , new ArrayList { 8, 4, 9 }
            },
            {
                new Student
                {
                FirstName ="Candice",
                LastName ="Leman"
                },
                new ArrayList{12,9,10}
            },
                        {
                new Student
                {
                FirstName ="Candice",
                LastName ="Leman Jr"
                },
                new ArrayList{13,8,10}
            }

        };
        static void RatingsList()
        {
            WriteLine("+++++++++++++ Список студентов с оценками++++++++++\n");
        foreach (Student student in group.Keys)
            {
                Write($"{student}: ");
                foreach (int item in (group[student] as
                ArrayList))
                {
                    Write($"{item} ");
                }
                WriteLine();
            }
        }
        static void SetRating(string name, int mark)
        {
            WriteLine($"\n+++++++++++++ Студент {name} получил оценку { mark}   ++++++\n");
        foreach (Student item in group.Keys)
            {
                if (item.LastName == name)
                {
                    (group[item] as ArrayList).Add(mark);
                }
            }
        }
        static void Main(string[] args)
        {
            RatingsList();
            SetRating("Leman", 11);
            RatingsList();
        }

    }
}
    