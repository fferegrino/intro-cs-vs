using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MstcIntroCs.Library.Elements.People
{
    // Student deriva de la clase Person:
    public class Student : Person
    {

        #region Constructores
        public Student(string name, string nickname)
            : base(name)
        {
            Nickname = nickname;
        }

        public Student(string name)
            : base(name)
        {

        }
        #endregion

        #region Propiedades ejemplo
        // Propiedad nullable
        public DateTime? GraduationDate { get; set; }
        // Equivalente: public Nullable<DateTime> { get; set; }
        #endregion

        #region Propiedades de Student
        public int Level { get; set; }

        /// <summary>
        /// Grade Point Average
        /// </summary>
        public decimal Gpa { get; set; }

        public string Nickname { get; set; }
        #endregion

        #region Métodos ejemplo
        /// <summary>
        /// Método sobreescrito:
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name + "(" + (Nickname ?? "no nickname") + ")";
        }

        /// <summary>
        /// Override the SayHello method from the base class
        /// </summary>
        /// <returns></returns>
        public override string SayHello()
        {
            return "Hi, I'm a student, my name is " + ToString();
        }
        #endregion



    }

}
