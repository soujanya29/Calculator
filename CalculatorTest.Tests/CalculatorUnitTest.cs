using CalculatorTest.BusinessLogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Tests
{
    [TestClass]
   public class CalculatorUnitTest
    {
        
        private Mock<ISimpleCalculator> _mockMathsImpl = new Mock<ISimpleCalculator>();
        private SimpleCalculatorMock _mock;

        public CalculatorUnitTest()
        {
            _mock = new SimpleCalculatorMock(_mockMathsImpl.Object);

        }


        [TestMethod]
        public void AdditionTest()
        {
            _mockMathsImpl.Setup(x => x.Add(2, 2)).Returns(4);
            var result = _mock.Add(2, 2);
            Assert.AreEqual(result, _mockMathsImpl.Object.Add(2, 2));
        }

        [TestMethod]
        public void SubtractTest()
        {
            _mockMathsImpl.Setup(x => x.Subtract(20, 10)).Returns(10);
            var result = _mock.Subtract(20, 10);
            Assert.AreEqual(result, _mockMathsImpl.Object.Subtract(20, 10));

        }
        [TestMethod]
        public void MultiplyTest()
        {
            _mockMathsImpl.Setup(x => x.Multiply(10, 2)).Returns(20);
            var result = _mock.Multiply(10, 2);
            Assert.AreEqual(result, _mockMathsImpl.Object.Multiply(10, 2));

        }


        [TestMethod]
        public void DivideTest()
        {

            _mockMathsImpl.Setup(x => x.Divide(10, 2)).Returns(5);
            var result = _mock.Divide(10, 2);
            Assert.AreEqual(result, _mockMathsImpl.Object.Divide(10, 2));

        }


        [TestMethod]
        public void DivideTest_DividebyZero()
        {
            _mockMathsImpl.Setup(x => x.Divide(24, 0)).Returns(-999);
            var result = _mock.Divide(24, 0);
            Assert.AreEqual(result, _mockMathsImpl.Object.Divide(24, 0));

        }

    }
}
