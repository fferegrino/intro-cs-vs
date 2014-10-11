using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MstcIntroCs.Library.Elements.People
{

    public enum Difficulty
    {
        SuperEasy,
        Easy,
        Normal,
        Hard,
        Impossible
    };

    public class Teacher : Person
    {
        #region Constructores
        public Teacher(string name)
            : base(name)
        {

        }
        #endregion


        #region Propiedades

        public Difficulty TeacherDifficulty { get; set; }

        #endregion

        /// <summary>
        /// This method does not override the one in Person class
        /// </summary>
        /// <returns></returns>
        public string SayHello()
        {
            return "Hi, I'm a teacher, my name is " + Name;
        }
    }
}
