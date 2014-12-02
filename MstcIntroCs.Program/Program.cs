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
            //Student s = new Student(String.Empty);
            //s.Name = "Antonio";
            //System.Console.WriteLine(s.Name);
            //s.Nickname = "Fere";
            //System.Console.WriteLine(s.Nickname);
            #endregion

            #region Indexers

            //Book java2 = new Book(100);
            //java2.Pages[0].PageNumber = 1;
            //java2[0].PageNumber = 1;

            #endregion

            #region Virtuals

            //Person student = new Student("Superstudent", "Coolkid");
            //Person teacher = new Teacher("Superteacher");
            //Teacher actualTeacher = (Teacher)teacher;

            //Console.WriteLine(student.SayHello());
            //Console.WriteLine(teacher.SayHello());

            //Console.WriteLine(actualTeacher.SayHello());

            #endregion

            #region Interfaces

            //IOpenable openableThing1 = new Book(10);
            //Door openableThing2 = new Door();
            //OpenSomething(openableThing1);
            //openableThing1.Open();
            //openableThing2.Open();

            #endregion

            #region Arreglos

            //char[] vocales = new char[5];
            //vocales[4] = 'u';
            //char[] vocales = null; new char[] { 'a', 'e', 'i', 'o', 'u' };
            //char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            //char[,] gato = new char[5, 3];
            //char[,] gato = // new char[,]
            //{
            //    {'o', 'x', 'o'},
            //    {'o', 'x', 'o'},
            //    {'o', 'x', 'o'}
            //};

            //char[][] gato = new char[3][];
            //{
            //    new char [] {'o', 'x'},
            //    new char [] {'o', 'x', 'o'},
            //    new char [] {'o'}
            //};
            #endregion

            #region Booleans

            //if (Funcion1(false) && Funcion2(true))
            //{
            //    Console.WriteLine("Hola!");
            //}

            //Console.WriteLine(new String('-', 10));

            //if (false && true)
            //{

            //}

            //if (Funcion1(false) & Funcion2(true))
            //{
            //    Console.WriteLine("Hola!");
            //}
            #endregion

            #region Enums
            //Teacher hardTeacher = new Teacher("Hard teacher");
            //hardTeacher.TeacherDifficulty = Difficulty.Easy;

            //switch (hardTeacher.TeacherDifficulty)
            //{
            //    case Difficulty.SuperEasy:
            //        break;
            //    case Difficulty.Impossible:
            //        break;
            //    default:
            //        break;
            //}

            #endregion

            #region Generics
            //Bus<Book> busOfBooks = new Bus<Book>();
            //Bus<Teacher> busOfTeachers = new Bus<Teacher>();
            #endregion

            #region Linq

            //Truck<Book> bookTruck = Truck<Book>.CreateSampleTruck();
            //Console.WriteLine(String.Format("The book truck has {0} items", bookTruck.Count));
            //List<Book> openedBooks = bookTruck.GetAllOpenedStuff();
            //Console.WriteLine(String.Format("The book truck has {0} opened items", openedBooks.Count));


            #endregion

            System.Console.ReadLine();
        }

        //                                vvvvvvvvv
        private static void OpenSomething(IOpenable thing)
        {
            thing.Open();
        }


        public static bool Funcion1(bool valor)
        {
            Console.WriteLine("Funcion uno");
            return valor;
        }

        public static bool Funcion2(bool valor)
        {
            Console.WriteLine("Funcion dos");
            return valor;
        }

    }
}
