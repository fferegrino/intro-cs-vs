using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MstcIntroCs.Library.Elements
{
    public class Student
    {
        #region Propiedades ejemplo
        // Propiedad autoimplementada:
        public string Name { get; set; }

        // Propiedad:
        private string _name;
        //// Propiedad completa:
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}


        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        // Propiedad nullable
        public DateTime? GraduationDate { get; set; }
        // Equivalent: public Nullable<DateTime> { get; set; }


        #endregion

        #region Propiedades de Student
        public int Level { get; set; }
        
        /// <summary>
        /// Grade Point Average
        /// </summary>
        public decimal Gpa { get; set; }

        public List<Course> Courses { get; set; }

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
        #endregion
    }
}
