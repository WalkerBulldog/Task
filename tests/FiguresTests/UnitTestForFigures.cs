using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;
using System.Runtime.InteropServices;

namespace FiguresTests
{
    [TestClass]
    public class UnitTestForFigures
    {
        [TestMethod]
        public void CirkleAreaTest()
        {
            //Arrange
            Random rnd = new Random();
            double R = rnd.Next(0, 10);
            double expArea = R * R * Math.PI;
            Cirkle test = new Cirkle(R);
            //Act
            double resArea = test.Area();
            //Assert
            Assert.AreEqual(expArea, resArea);
        }
        [TestMethod]
        public void HexagonAreaTest()
        {
            //Arrange
            Random rnd = new Random();
            double e = rnd.Next(0, 10);
            double expArea = 3 * Math.Sqrt(3) * e * e / 2;
            Hexagon test = new Hexagon(e);
            //Act
            double resArea = test.Area();
            //Assert
            Assert.AreEqual(expArea, resArea);
        }
        [TestMethod]
        public void SquareAreaTest()
        {
            //Arrange
            Random rnd = new Random();
            double e = rnd.Next(0, 10);
            double expArea =  e * e;
            Square test = new Square(e);
            //Act
            double resArea = test.Area();
            //Assert
            Assert.AreEqual(expArea, resArea);
        }
        [TestMethod]
        public void RectangleAreaTest()
        {
            //Arrange
            Random rnd = new Random();
            double e1 = rnd.Next(0, 10);
            double e2 = rnd.Next(0, 10);
            double expArea = e1 * e2;
            Rectangle test = new Rectangle(e1, e2);
            //Act
            double resArea = test.Area();
            //Assert
            Assert.AreEqual(expArea, resArea);
        }
        [TestMethod]
        public void TrapezoidAreaTest()
        {
            //Arrange
            Random rnd = new Random();
            double e1 = rnd.Next(0, 10);
            double e2 = rnd.Next(0, 10);
            double h = rnd.Next(0, 10);
            double expArea = (e1 + e2) *h / 2;
            Trapezoid test = new Trapezoid(e1, e2, h);
            //Act
            double resArea = test.Area();
            //Assert
            Assert.AreEqual(expArea, resArea);
        }
        [TestMethod]
        public void TriangleAreaTest()
        {
            //Arrange
            Random rnd = new Random();
            double e1 = rnd.Next(0, 10);
            double h = rnd.Next(0, 10);
            double expArea = e1 * h / 2;
            Triangle test = new Triangle(e1, h);
            //Act
            double resArea = test.Area();
            //Assert
            Assert.AreEqual(expArea, resArea);
        }
        [TestMethod]
        public void CirklePerimeterTest()
        {
            //Arrange
            Random rnd = new Random();
            double R = rnd.Next(0, 10);
            double expPer = 2 * Math.PI * R;
            Cirkle test = new Cirkle(R);
            //Act
            double resPer = test.Perimeter();
            //Assert
            Assert.AreEqual(expPer, resPer);
        }
        [TestMethod]
        public void HexagonPerimeterTest()
        {
            //Arrange
            Random rnd = new Random();
            double e = rnd.Next(0, 10);
            double expPer = e * 6;
            Hexagon test = new Hexagon(e);
            //Act
            double resPer = test.Perimeter();
            //Assert
            Assert.AreEqual(expPer, resPer);
        }
        [TestMethod]
        public void SquarePerimeterTest()
        {
            //Arrange
            Random rnd = new Random();
            double e = rnd.Next(0, 10);
            double expPer = e * 4;
            Square test = new Square(e);
            //Act
            double resPer = test.Perimeter();
            //Assert
            Assert.AreEqual(expPer, resPer);
        }
        [TestMethod]
        public void RectanglePerimeterTest()
        {
            //Arrange
            Random rnd = new Random();
            double e1 = rnd.Next(0, 10);
            double e2 = rnd.Next(0, 10);
            double expPer = 2 * (e1 + e2);
            Rectangle test = new Rectangle(e1, e2);
            //Act
            double resPer = test.Perimeter();
            //Assert
            Assert.AreEqual(expPer, resPer);
        }
        [TestMethod]
        public void TrapezoidPerimeterTest()
        {
            //Arrange
            Random rnd = new Random();
            double e1 = rnd.Next(0, 10);
            double e2 = rnd.Next(0, 10);
            double h = rnd.Next(0, 10);
            double e = Math.Sqrt(h * h + (e1 - e2) *(e1 - e2) / 4);
            double expPer = 2 * e + e1 + e2;
            Trapezoid test = new Trapezoid(e1, e2, h);
            //Act
            double resPer = test.Perimeter();
            //Assert
            Assert.AreEqual(expPer, resPer);
        }
        [TestMethod]
        public void TrianglePerimeterTest()
        {
            //Arrange
            Random rnd = new Random();
            double e1 = rnd.Next(0, 10);
            double h = rnd.Next(0, 10);
            double e = Math.Sqrt(h * h  + e1 * e1 / 4);
            double expPer = 2 * e + e1;
            Triangle test = new Triangle(e1, h);
            //Act
            double resPer = test.Perimeter();
            //Assert
            Assert.AreEqual(expPer, resPer);
        }
    }
}
