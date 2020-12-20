using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbers;
using CompleksNumberUI;
using Exceptions;
using ComplexNumberCheck;

namespace UnitTestComplexNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionComplexNumber1()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(3, -1);
            ComplexNumber firstTestNumber = new ComplexNumber(2, 3);
            ComplexNumber secondTestNumber = new ComplexNumber(1, -4);
            //Act
            ComplexNumber resultAddition = new ComplexNumber();
            resultAddition = firstTestNumber + secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultAddition);
        }
        [TestMethod]
        public void MultiplicationComplexNumber1()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(14, -5);
            ComplexNumber firstTestNumber = new ComplexNumber(2, 3);
            ComplexNumber secondTestNumber = new ComplexNumber(1, -4);
            //Act
            ComplexNumber resultMultiplication = new ComplexNumber();
            resultMultiplication = firstTestNumber * secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultMultiplication);
        }
        [TestMethod]
        public void AdditionComplexNumber2()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(-1, 5);
            ComplexNumber firstTestNumber = new ComplexNumber(4, 2);
            ComplexNumber secondTestNumber = new ComplexNumber(-5, 3);
            //Act
            ComplexNumber resultAddition = new ComplexNumber();
            resultAddition = firstTestNumber + secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultAddition);
        }
        [TestMethod]
        public void MultiplicationComplexNumber2()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(-26, 2);
            ComplexNumber firstTestNumber = new ComplexNumber(4, 2);
            ComplexNumber secondTestNumber = new ComplexNumber(-5, 3);
            //Act
            ComplexNumber resultMultiplication = new ComplexNumber();
            resultMultiplication = firstTestNumber * secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultMultiplication);
        }
        [TestMethod]
        public void AdditionComplexNumber3()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(7, -4);
            ComplexNumber firstTestNumber = new ComplexNumber(2, 3);
            ComplexNumber secondTestNumber = new ComplexNumber(5, -7);
            //Act
            ComplexNumber resultAddition = new ComplexNumber();
            resultAddition = firstTestNumber + secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultAddition);
        }
        [TestMethod]
        public void MultiplicationComplexNumber3()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(31, 1);
            ComplexNumber firstTestNumber = new ComplexNumber(2, 3);
            ComplexNumber secondTestNumber = new ComplexNumber(5, -7);
            //Act
            ComplexNumber resultMultiplication = new ComplexNumber();
            resultMultiplication = firstTestNumber * secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultMultiplication);
        }
        [TestMethod]
        public void AdditionComplexNumber4()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(3, 4);
            ComplexNumber firstTestNumber = new ComplexNumber(-2, -3);
            ComplexNumber secondTestNumber = new ComplexNumber(5, 7);
            //Act
            ComplexNumber resultAddition = new ComplexNumber();
            resultAddition = firstTestNumber + secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultAddition);
        }
        [TestMethod]
        public void MultiplicationComplexNumber4()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(11, -29);
            ComplexNumber firstTestNumber = new ComplexNumber(-2, -3);
            ComplexNumber secondTestNumber = new ComplexNumber(5, 7);
            //Act
            ComplexNumber resultMultiplication = new ComplexNumber();
            resultMultiplication = firstTestNumber * secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultMultiplication);
        }
        [TestMethod]
        public void AdditionComplexNumber5()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(-7, -10);
            ComplexNumber firstTestNumber = new ComplexNumber(-2, -3);
            ComplexNumber secondTestNumber = new ComplexNumber(-5, -7);
            //Act
            ComplexNumber resultAddition = new ComplexNumber();
            resultAddition = firstTestNumber + secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultAddition);
        }
        [TestMethod]
        public void MultiplicationComplexNumber5()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(-11, 29);
            ComplexNumber firstTestNumber = new ComplexNumber(-2, -3);
            ComplexNumber secondTestNumber = new ComplexNumber(-5, -7);
            //Act
            ComplexNumber resultMultiplication = new ComplexNumber();
            resultMultiplication = firstTestNumber * secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultMultiplication);
        }
        [TestMethod]
        public void AdditionComplexNumber6()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(-7, -3);
            ComplexNumber firstTestNumber = new ComplexNumber(-2, -3);
            ComplexNumber secondTestNumber = new ComplexNumber(-5, 0);
            //Act
            ComplexNumber resultAddition = new ComplexNumber();
            resultAddition = firstTestNumber + secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultAddition);
        }
        [TestMethod]
        public void MultiplicationComplexNumber6()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(10, 15);
            ComplexNumber firstTestNumber = new ComplexNumber(-2, -3);
            ComplexNumber secondTestNumber = new ComplexNumber(-5, 0);
            //Act
            ComplexNumber resultMultiplication = new ComplexNumber();
            resultMultiplication = firstTestNumber * secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultMultiplication);
        }
        [TestMethod]
        public void AdditionComplexNumber7()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(-5, -3);
            ComplexNumber firstTestNumber = new ComplexNumber(0, -3);
            ComplexNumber secondTestNumber = new ComplexNumber(-5, 0);
            //Act
            ComplexNumber resultAddition = new ComplexNumber();
            resultAddition = firstTestNumber + secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultAddition);
        }
        [TestMethod]
        public void MultiplicationComplexNumber7()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(0, 15);
            ComplexNumber firstTestNumber = new ComplexNumber(0, -3);
            ComplexNumber secondTestNumber = new ComplexNumber(-5, 0);
            //Act
            ComplexNumber resultMultiplication = new ComplexNumber();
            resultMultiplication = firstTestNumber * secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultMultiplication);
        }
        [TestMethod]
        public void AdditionComplexNumber8()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(2, 3);
            ComplexNumber firstTestNumber = new ComplexNumber(2, 3);
            ComplexNumber secondTestNumber = new ComplexNumber(0, 0);
            //Act
            ComplexNumber resultAddition = new ComplexNumber();
            resultAddition = firstTestNumber + secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultAddition);
        }
        [TestMethod]
        public void MultiplicationComplexNumber8()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(0, 0);
            ComplexNumber firstTestNumber = new ComplexNumber(2, 3);
            ComplexNumber secondTestNumber = new ComplexNumber(0, 0);
            //Act
            ComplexNumber resultMultiplication = new ComplexNumber();
            resultMultiplication = firstTestNumber * secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultMultiplication);
        }
        [TestMethod]
        public void AdditionComplexNumber9()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(0, 2);
            ComplexNumber firstTestNumber = new ComplexNumber(5, -3);
            ComplexNumber secondTestNumber = new ComplexNumber(-5, 5);
            //Act
            ComplexNumber resultAddition = new ComplexNumber();
            resultAddition = firstTestNumber + secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultAddition);
        }
        [TestMethod]
        public void MultiplicationComplexNumber9()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(-10, 40);
            ComplexNumber firstTestNumber = new ComplexNumber(5, -3);
            ComplexNumber secondTestNumber = new ComplexNumber(-5, 5);
            //Act
            ComplexNumber resultMultiplication = new ComplexNumber();
            resultMultiplication = firstTestNumber * secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultMultiplication);
        }
        [TestMethod]
        public void AdditionComplexNumber10()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(7, 10);
            ComplexNumber firstTestNumber = new ComplexNumber(2, 3);
            ComplexNumber secondTestNumber = new ComplexNumber(5, 7);
            //Act
            ComplexNumber resultAddition = new ComplexNumber();
            resultAddition = firstTestNumber + secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultAddition);
        }
        [TestMethod]
        public void MultiplicationComplexNumber10()
        {
            //Arange
            ComplexNumber expected = new ComplexNumber(-11, 29);
            ComplexNumber firstTestNumber = new ComplexNumber(2, 3);
            ComplexNumber secondTestNumber = new ComplexNumber(5, 7);
            //Act
            ComplexNumber resultMultiplication = new ComplexNumber();
            resultMultiplication = firstTestNumber * secondTestNumber;
            //Assert
            Assert.AreEqual(expected, resultMultiplication);
        }
        [TestMethod]
        public void ExceptionIncorectValue()
        {
            //Arange
            int check;
            bool flag = false;
            bool expected = true;
            //Act
            try
            {
                CheckException.CheckInput("sdc", out check);
            }
            catch
            {
                flag = true;
            }
            //Assert
            Assert.AreEqual(expected, flag);
        }
        [TestMethod]
        public void ExceptionCorectValue()
        {
            //Arange
            int check;
            bool flag = false;
            bool expected = false;
            //Act
            try
            {
                CheckException.CheckInput("2", out check);
            }
            catch
            {
                flag = true;
            }
            //Assert
            Assert.AreEqual(expected, flag);
        }
        [TestMethod]
        public void ExceptionCorectMinusValue()
        {
            //Arange
            int check;
            bool flag = false;
            bool expected = false;
            //Act
            try
            {
                CheckException.CheckInput("-5", out check);
            }
            catch
            {
                flag = true;
            }
            //Assert
            Assert.AreEqual(expected, flag);
        }
        [TestMethod]
        public void ExceptionIncorectMinusValue()
        {
            //Arange
            int check;
            bool flag = false;
            bool expected = true;
            //Act
            try
            {
                CheckException.CheckInput("-", out check);
            }
            catch
            {
                flag = true;
            }
            //Assert
            Assert.AreEqual(expected, flag);
        }
        [TestMethod]
        public void CorectMinusValue()
        {
            //Arange
            int check;
            int expected = -5;
            //Act
            CheckException.CheckInput("-5", out check);
            //Assert
            Assert.AreEqual(expected, check);
        }
        [TestMethod]
        public void CorectValue()
        {
            //Arange
            int check;
            int expected = 2;
            //Act
            CheckException.CheckInput("2", out check);
            //Assert
            Assert.AreEqual(expected, check);
        }
        [TestMethod]
        public void ExceptionIncorectSelected()
        {
            //Arange
            int check = 2;
            bool flag = false;
            bool expected = true;
            //Act
            try
            {
                CheckException.CheckSelectedItemsCount(1, check);
            }
            catch
            {
                flag = true;
            }
            //Assert
            Assert.AreEqual(expected, flag);
        }
        [TestMethod]
        public void ExceptionIncorectSelectedZero()
        {
            //Arange
            int check = 2;
            bool flag = false;
            bool expected = true;
            //Act
            try
            {
                CheckException.CheckSelectedItemsCount(0, check);
            }
            catch
            {
                flag = true;
            }
            //Assert
            Assert.AreEqual(expected, flag);
        }
        [TestMethod]
        public void ExceptionCorectSelected()
        {
            //Arange
            int check = 2;
            bool flag = false;
            bool expected = false;
            //Act
            try
            {
                CheckException.CheckSelectedItemsCount(2, check);
            }
            catch
            {
                flag = true;
            }
            //Assert
            Assert.AreEqual(expected, flag);
        }
    }
}
