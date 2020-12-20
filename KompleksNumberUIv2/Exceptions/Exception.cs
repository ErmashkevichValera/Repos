using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// Class exception incorrect value 
    /// </summary>
    public class IncorrectValueException : Exception
    {
        public IncorrectValueException() : base("Incorrect value")
        {
        }
        public IncorrectValueException(string message) : base(message)
        {
        }
    }
    /// <summary>
    /// Class exception incorrect selected 
    /// </summary>
    public class IncorrectSelectedException : Exception
    {
        public IncorrectSelectedException() : base("Incorrect selected")
        {
        }
        public IncorrectSelectedException(string message) : base(message)
        {
        }
    }
}
