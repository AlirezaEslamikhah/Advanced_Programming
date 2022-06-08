using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace C13.Tests
{

    [TestClass]
    public class UnitTest1
    {
        // public static void Sort<_Type>(_Type[] nums, Func<_Type, _Type, bool> cmp)
        // {
        //     for(int i=0; i<nums.Length; i++)
        //         for (int j=i; j<nums.Length; j++)
        //             if (cmp(nums[i], nums[j]))
        //                 Swap<_Type>(nums, i, j);
        // }

        // class Point
        // {
        //     public Point(int x, int y){this.X = x; this.Y = y;}
        //     public int X; 
        //     public int Y; 
        //     public int Magnitude 
        //     {
        //         get => Math.Sqrt(X*X + Y*Y);
        //     }
        // }

        [TestMethod]
        public void TestSortPointX()
        {
            // Point[] points = new Point[]{new Point(2,3), new Point(1, 4), new Point(2, 3)};
            // Sort<Point>(points, (p1, p2) => p1.X < p2.X);

        }

        [TestMethod]
        public void TestSortPointY()
        {
        }

        [TestMethod]
        public void TestSortPointMagnitude()
        {
        }

    }
}
