using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT2.Invoice.Utilities.Exceptions
{
    public class IT2Exception: Exception
    {
        public IT2Exception()
        {
        }

        public IT2Exception(string message)
            : base(message)
        {
        }

        public IT2Exception(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
