using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AwesomeCalculator;

namespace Calculator
{
    public class sClass1
    {

        [TestFixture]
        class CalcTests
        {
            [Test]
            public void GetAddition_Input30and40_Returns70()



            {
                //Arrange
                double number1 = 30;
                double number2 = 40;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetAddition();
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

        }
        [Test]
        public void GetAddition_Input3point5and4point5Returns8()

        {
            //Arrange
            double number1 = 3.5;
            double number2 = 4.5;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input7and4Returns11()

        {
            //Arrange
            double number1 = 7;
            double number2 = 4;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input8pointand4Repoint5turns4()

        {
            //Arrange
            double number1 = 8.5;
            double number2 = 4.5;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    
    [Test]
    public void GetSubtraction_Input8tand4Returns4()

    {
        //Arrange
        double number1 = 8;
        double number2 = 4;
        double expectedResult = number1 - number2;
        Calc testCalc = new Calc(number1, number2);
        //Act
        double actualResult = testCalc.GetSubtraction();
        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
        [Test]
        public void GetSubtraction_Input200tand40Returns160()

        {
            //Arrange
            double number1 = 200;
            double number2 = 40;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input8tand4Returns32()

        {
            //Arrange
            double number1 = 8;
            double number2 = 4;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }    
}
