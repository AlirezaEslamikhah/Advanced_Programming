using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C5.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Point p = new Point(2, 3, 4);
            Point p2 = new Point(2, 0, 8);
            Assert.AreEqual(p.DistanceTo(p2), 5);

            Assert.AreEqual(C5.Point.DistanceTo(p, p), 0);
            Assert.AreEqual(C5.Point.DistanceTo(p, p2), 5);

            Assert.AreEqual(
                C5.Point.DistanceTo(p, p2),
                C5.Point.DistanceTo(p2, p));

        }
    }
}