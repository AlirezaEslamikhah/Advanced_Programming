// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System;

// namespace C10.Tests
// {
//     [TestClass]
//     public class UnitTest1
//     {
//         [TestMethod]
//         public void PointXSortTest()
//         {
//             Point[] points = new Point[]{
//                 new Point(5, 4),
//                 new Point(2, 3),
//                 new Point(1, 11),
//                 new Point(-2, 2),
//                 new Point(15, -3)
//             };

//             Program.Sort(points, PointComparer.PointXComparer);

//             Assert.AreEqual(points[0].X, -2);
//             Assert.AreEqual(points[0].Y, 2);
//             Assert.AreEqual(points[1].X, 1);
//             Assert.AreEqual(points[1].Y, 11);
//             // ...

//             throw new NotImplementedException();
//         }

//         [TestMethod]
//         public void PointYSortTest()
//         {
//             throw new NotImplementedException();
//         }

//         [TestMethod]
//         public void PointMagnitudeSortTest()
//         {
//             throw new NotImplementedException();
//         }
//     }
// }
