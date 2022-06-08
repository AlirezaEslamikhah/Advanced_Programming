using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C6.Test
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void ShapeConstructorTest()
        {
            s = new Shape("window", 4);
            p = new Point();
            p.X = 3;
            p.Y = 2;
            s.UpdateCorner(0, p);
            p.Y = 3;
            s.UpdateCorner(1, p);
            p.X = 3;
            s.UpdateCorner(2, p);
            p.Y = 1; 
            s.UpdateCorner(3, p);
            Assert.AreEqual(s.GetCorner(0).X,3);
            Assert.AreEqual(s.GetCorner(0).Y,2);
        }

        [TestMethod]
        public void GetCornerTest()
        {
            // Assert.AreEqual(s.GetCorner(0).X,3);
        }

        [TestMethod]
        public void UpdateCornerTest()
        {

        }

        [TestMethod]
        public void ExchangeCornerTest()
        {
            s = new Shape("window", 4);
            p = new Point{X=1, Y=2};
            s.UpdateCorner(0, p);
            p.Y = 3;
            s.UpdateCorner(1, p);
            p.X = 3;
            s.UpdateCorner(2, p);
            p.Y = 1; 
            s.UpdateCorner(3, p);

            s.ExchangeCorners(0, 2);
            Assert.AreEqual(s.GetCorner(0).X , 3);
            Assert.AreEqual(s.GetCorner(0).Y , 3);
        }
        public Shape s;
        public Point p;
    }
}
