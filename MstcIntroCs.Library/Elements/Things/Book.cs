using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MstcIntroCs.Library.Elements.Things
{
    public class Book : IOpenable
    {

        public Book()
            : this(100)
        {

        }

        public Book(int numberPages)
        {
            pages = new Page[numberPages];
        }

        #region Propiedades
        public int CountPages { get; private set; }

        /// <summary>
        /// Arreglo de Pages
        /// </summary>
        private Page[] pages;

        /// <summary>
        /// Propiedad pages
        /// </summary>
        public Page[] Pages { get { return pages; } set { pages = value; } }

        public Page this[int index]
        {
            get { return pages[index]; }
            set { pages[index] = value; }
        }
        
        #endregion


        #region Implementing IOpenable interface
        public void Open()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }



        public bool IsClosed { get; set; }

        public int TimesOpened { get; set; }
        #endregion
    }
}