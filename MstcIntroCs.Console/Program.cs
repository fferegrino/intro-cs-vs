using MstcIntroCs.Library.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MstcIntroCs.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Antonio";
            System.Console.WriteLine(s);
            s.Nickname = "Fere";
            System.Console.WriteLine(s);
            System.Console.ReadLine();
        }
    }
}
