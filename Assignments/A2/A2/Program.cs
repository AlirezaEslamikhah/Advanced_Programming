using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A2;

namespace A2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // String b = "lll"; 
            int[] z = new int[]{2};
            int y = 0;
            int a = System.Runtime.InteropServices.Marshal.SizeOf(typeof(TypeOfSize32768));
            // Console.WriteLine(typeof(y));

        }
        
        public static int GetObjectType(object o)
        {
            int a=0;
            if (o.GetType() == typeof(string))
            {
                a=0;
            }
            else if (o.GetType()==typeof(int[]))
            {
                a=1;
            }
            else if (o.GetType()==typeof(int))
            {
                a = 2;
            }
            // else{}
            return a;
        }

        public static bool IdealHusband(FutureHusbandType fht)
        {
            bool k = true;
            if ((int)fht == 2)
            {
                k = false;
            }
            else if ((int)fht == 4)
            {
                k = false;
            }
            else if((int)fht == 8)
            {
                k = false;
            }
            else if((int)fht == 12)
            {
                k = true;
            }
            else if((int)fht == 6)
            {
                k = true;
            }
            else if((int)fht == 10)
                k = true;
            else if((int)fht == 14)
                k = false;
            return k;
        }
    }
}
