using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MstcIntroCs.Library.Elements.Things
{
    public class Truck<T> where T : IOpenable, new()
    {
        private List<T> items;

        #region Propiedades

        public int Count
        {
            get { return items.Count; }
        }

        #endregion

        #region Métodos

        public Truck()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> GetAllOpenedStuff()
        {
            //var q = from a in items
            //        where a.IsClosed == false
            //        select a;

            var q = items
                        .Where(a => a.IsClosed == false)
                        .Select(a => a);

            return q.ToList();
        }

        #endregion

        #region Statics

        public static Truck<T> CreateSampleTruck()
        {
            var a = Enumerable.Range(0, 20)
                .Select(i => new T
                {
                    IsClosed = i % 2 == 0,
                    TimesOpened = (i * i) + i
                });
            Truck<T> result = new Truck<T>();

            foreach (var x in a)
            {
                result.Add(x);
            }

            return result;
        }

        #endregion

    }
}
