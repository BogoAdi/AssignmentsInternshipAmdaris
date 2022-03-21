using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentExceptions
{
    internal class CounterException :Exception
    {
        public CounterException()
        {
        }

        public CounterException(string message) : base(message)
        {
            Console.WriteLine(message + "Counter is increasing ");
        }

        public CounterException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine(message + "Counter is increasing for " + innerException.Message);
        }
    }
}
