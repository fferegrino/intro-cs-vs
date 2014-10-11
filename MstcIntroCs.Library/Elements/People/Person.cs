using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MstcIntroCs.Library.Elements.People
{
    public class Person
    {

        #region Constructors
        public Person(string name)
        {
            Name = name;
        }
        #endregion

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
        #endregion

        #region Propiedades
        public DateTime DateOfBirth { get; set; }
        #endregion

        public virtual string SayHello()
        {
            return "Hi, I'm a person, my name is " + Name;
        }
    }
}
