using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_LB4_1;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Rectangle_Perimeter_ReturnsCorrectValue()
        {
            // Arrange
            var rectangle = new Rectangle(5.0, 3.0);
            double expected = 16.0; // (5 + 3) * 2

            // Act
            double actual = rectangle.Perimeter();

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}
