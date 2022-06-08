using System;

namespace A0
{
    public class Program
    {
        public static int max(int a,int b)
        {
            if(a>b)
                return a;
            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(max(5,15));
        }
    }
}
