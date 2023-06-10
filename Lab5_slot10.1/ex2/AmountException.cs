using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project24
{
    class AmountException : Exception
    {
        public string PersonName { get; }

        public AmountException(string personName, string message) : base(message)
        {
            PersonName = personName;
        }
    }
}
