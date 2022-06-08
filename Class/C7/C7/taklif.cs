
using System;

namespace C7
{
    class Point
    {
        public  void getter()
        {
            Console.Write("ENTER FIRST NUMBER");
            x=Console.ReadLine();
            X = int.Parse(x);
            Console.Write("ENTER SECOND NUMBER");
            y=Console.ReadLine();
            Y = int.Parse(y);
        }

        public Point(){}
        public Point getterc()
        {
            return z;
        }

        public void bargasht()
        {
            Console.Write(X-Y);
        }

        
        static void Main (string[] args)
        {
            Point p;
            p = new Point();
            p.getter();
            p.bargasht();
            // Console.Write(p.getterc().X);
            
        }


        private string x;
        public double X;
        private double Y;
        private string y;
        public Point z;
    }
}