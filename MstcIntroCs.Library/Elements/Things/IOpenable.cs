using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MstcIntroCs.Library.Elements.Things
{
    public interface IOpenable
    {
        bool IsClosed { get; set; }
        int TimesOpened { get; set; }

        void Open();

        void Close();
    }
}
