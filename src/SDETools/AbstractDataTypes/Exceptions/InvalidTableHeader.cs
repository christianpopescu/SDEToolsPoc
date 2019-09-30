using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDataTypes.Exceptions
{
    public class InvalidTableHeader : Exception
    {
        public override string Message => "Invalid Header Exception";
    }
}
