using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MstcIntroCs.Library.Elements.Things
{
    public class Bus<T> // where T : People.Person
    {
        public int Capacity { get; private set; }
        public People.Person Driver { get; set; }
        private Queue<T> passengers;

        public bool AddPassenger(T passenger)
        {
            if (passengers.Count < Capacity)
            {
                passengers.Enqueue(passenger);
                return true;
            }
            return false;
        }

        public T PopPassenger()
        {
            return passengers.Dequeue();
        }
    }
}
