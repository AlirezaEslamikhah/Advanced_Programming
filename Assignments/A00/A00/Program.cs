using System;

namespace A00
{
    public class Program
    {
        public static bool get_prime(int a,int b)
        {
            if(a>b)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(get_prime(5,15));
        }
    }
}
