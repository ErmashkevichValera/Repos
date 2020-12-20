using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;


namespace ComplexNumbers
{
    /// <summary>
    /// Class comple number
    /// </summary>
    public class ComplexNumber
    {
        /// <summary>
        /// Initializes a new instance of the class
        /// </summary>
        public ComplexNumber(int validPart, int imaginaryPart)
        {
            this.validPart = validPart;
            this.imaginaryPart = imaginaryPart;
        }
        /// <summary>
        /// Initializes a new instance of the class
        /// </summary>
        public ComplexNumber()
        {

        }
        public int validPart;
        public int imaginaryPart;
        /// <summary>
        /// Overload operator +
        /// </summary>
        /// <returns>Result complex number</returns>
        public static ComplexNumber operator +(ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            int valid = firstNumber.validPart + secondNumber.validPart;
            int imaginary = firstNumber.imaginaryPart + secondNumber.imaginaryPart;
            ComplexNumber result = new ComplexNumber(valid, imaginary);
            return result;
        }
        /// <summary>
        /// Overload operator *
        /// </summary>
        /// <returns>Result complex number</returns>
        public static ComplexNumber operator *(ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            int valid = (firstNumber.validPart * secondNumber.validPart - firstNumber.imaginaryPart *
                secondNumber.imaginaryPart);
            int imaginary = (firstNumber.validPart * secondNumber.imaginaryPart +
                firstNumber.imaginaryPart * secondNumber.validPart);
            ComplexNumber result = new ComplexNumber(valid, imaginary);
            return result;
        }
        /// <summary>
        /// Method for comparison complex nubers
        /// </summary>
        /// <returns>Equal are the numbers</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                ComplexNumber checkNumber = (ComplexNumber)obj;
                return (validPart == checkNumber.validPart) && (imaginaryPart == checkNumber.imaginaryPart);
            }
        }

    }
}
