using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;

namespace ComplexNumberCheck
{
    public static class CheckException
    {
        /// <summary>
        /// Method for check input value
        /// </summary>
        public static void CheckInput(string input, out int number)
        {
            if (!int.TryParse(input, out number))
                throw new IncorrectValueException("Conversion error occured, argument not egual number");
        }
        public static void CheckSelectedItemsCount(int inputSelected, int checkedItemsLimit)
        {
            if(inputSelected != checkedItemsLimit)
                throw new IncorrectSelectedException("Not two Numbers selsected");
        }
    }
}
