using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnSum()
        {
            var calculator = new Calculator();

            Assert.True(10 == calculator.Additional(5, 5));
        }

        [Test]
        public void SubtractionMustReturnTen()
        {
            var calculator = new Calculator();
                        
            Assert.True(10 == calculator.Subtraction(15, 5));
        }

        [Test]
        public void MultiplicationMustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.AreEqual(25 , calculator.Miltiplication(5, 5));
        }

        [Test]
        public void DivisionMustReturnNotNullValue()
        {
            var calculator = new Calculator();

            Assert.AreEqual(1, calculator.Division(5, 5));
        }

    }
}
