using System;

namespace C5
{
    public class Point
    {
        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double DistanceTo(Point other)
        {
            double w = Math.Pow(X-other.X,2) + Math.Pow(Y-other.Y,2) + Math.Pow(Z-other.Z,2);
            double S = Math.Sqrt(w);
            return S;
        }

        public static double DistanceTo(Point a, Point b)
        {
            double w = Math.Pow(a.X-b.X,2) + Math.Pow(a.Y-b.Y,2) + Math.Pow(a.Z-b.Z,2);
            double S = Math.Sqrt(w);
            return S;
        }


        public void PrintInfo()
        {
            Console.WriteLine(X);
            Console.WriteLine(Y);
            Console.WriteLine(Z);
        }
        // static void Main(string[] args){}

        public int X;
        public int Y;
        public int Z;
    }



    struct PointValue
    {
        public PointValue(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double DistanceTo(Point other)
        {
            double w = Math.Pow(X-other.X,2) + Math.Pow(Y-other.Y,2) + Math.Pow(Z-other.Z,2);
            double S = Math.Sqrt(w);
            return S;
        }

        public static double DistanceTo(Point a, Point b)
        {
            double w = Math.Pow(a.X-b.X,2) + Math.Pow(a.Y-b.Y,2) + Math.Pow(a.Z-b.Z,2);
            double S = Math.Sqrt(w);
            return S;
        }

        public void PrintInfo()
        {
            Console.WriteLine(X);
            Console.WriteLine(Y);
            Console.WriteLine(Z);
        }

        public int X;
        public int Y;
        public int Z;
    }
}