using Microsoft.VisualStudio.TestTools.UnitTesting;
using Square;

namespace LibraryTest
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void circlereturned100pi()
        {
            //arrange
            double x = 10;
            double expected = 314.1592653589793;

            //act
            SquareCounter square = new SquareCounter();
            double actual = square.GetSquare(x);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void triangle345returned6()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            SquareCounter sc = new SquareCounter();
            var actual = sc.GetSquare(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void triangle345isrect()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            SquareCounter sc = new SquareCounter();
            sc.GetSquare(a, b, c);
            bool actual = sc.isRect();

            Assert.AreEqual(expected, actual);
        }
    }
}
