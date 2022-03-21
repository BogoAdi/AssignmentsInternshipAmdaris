using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentExceptions
{
    public class ExceptionDividedBy3 : Exception
    {
        public ExceptionDividedBy3()
        {
        }

        public ExceptionDividedBy3(string message) : base(message)
        {
            Console.WriteLine(message + " can be diveded by 3 ");
        }

        public ExceptionDividedBy3(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine(message + " can be diveded by 3 " + innerException);
        }
    }
}