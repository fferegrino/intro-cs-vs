using MstcIntroCs.Library.Elements.People;
using MstcIntroCs.Library.Elements.Things;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MstcIntroCs.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Properties
            Student s = new Student(String.Empty);
            s.Name = "Antonio";
            System.Console.WriteLine(s.Name);
            s.Nickname = "Fere";
            System.Console.WriteLine(s.Nickname);
            #endregion

            #region Indexers

            Book java2 = new Book(100);
            java2.Pages[0].PageNumber = 1;
            java2[0].PageNumber = 1;

            #endregion

            #region Virtuals

            Person student = new Student("Superstudent", "Coolkid");
            Person teacher = new Teacher("Superteacher");
            Teacher actualTeacher = (Teacher)teacher;

            Console.WriteLine(student.SayHello());
            Console.WriteLine(teacher.SayHello());

            Console.WriteLine(actualTeacher.SayHello());

            #endregion

            #region Interfaces

            IOpenable openableThing1 = new Book(10);
            Door openableThing2 = new Door();
            OpenSomething(openableThing1);
            openableThing1.Open();
            openableThing2.Open();

            #endregion

            #region Enums
            Teacher hardTeacher = new Teacher("Hard teacher");
            hardTeacher.TeacherDifficulty = Difficulty.Easy;

            switch (hardTeacher.TeacherDifficulty)
            {
                case Difficulty.SuperEasy:
                    break;
                case Difficulty.Impossible:
                    break;
                default:
                    break;
            }

            #endregion

            #region Generics
            Bus<Book> busOfBooks = new Bus<Book>();
            Bus<Teacher> busOfTeachers = new Bus<Teacher>();
            #endregion

            System.Console.ReadLine();
        }

        //                                vvvvvvvvv
        private static void OpenSomething(IOpenable thing)
        {
            thing.Open();
        }
    }
}
