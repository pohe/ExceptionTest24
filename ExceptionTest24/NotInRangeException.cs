using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest24
{
    public class NotInRangeException :Exception
    {
        public NotInRangeException():base()
        {
        }

        public NotInRangeException(string message): base(message)
        {
            
        }

    }
}
