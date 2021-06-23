using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    interface IPhone
    {
        interface Phone
        {
            string Manufacturer { get; }

            string ModelNumber { get; }

            bool KeypadPresent { get; set; }

            void Makecalls();

            void Receivecalls();

        }
    }
}




