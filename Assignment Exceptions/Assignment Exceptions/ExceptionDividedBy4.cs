using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentExceptions
{
    public class ExceptionDividedBy4 : Exception
    {
        public ExceptionDividedBy4()
        {
        }

        public ExceptionDividedBy4(string message) : base(message)
        {
            Console.WriteLine(message+ " can be diveded by 4 ");
        }

        public ExceptionDividedBy4(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine(message + " can be diveded by 4 "+ innerException);
        }
    }
}
