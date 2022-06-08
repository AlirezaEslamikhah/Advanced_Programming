using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
	public interface IHasAge
	{
		int GetAge();
	}
	public class BasicQuestions
	{
		public static void AssignPi(ref double a)
		{
			a = Math.PI;
			// return a;
		}
		public static void Square( ref int a)
		{
			a = a*a;
		}
		public static void Append(ref int[] a ,ref int b)
		{
			int[] c = new int[a.Length+1];
			for (int i = 0; i < a.Length; i++)
			{
				c[i] = a[i];
			}
			c[(a.Length)] = b;
			a = c;
		}
		public static void AbsArray(ref int[] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i]<= 0)
				{
					a[i] = a[i] * -1;
				}
			}
		}
		public static void Swap(ref int[]a , ref int[]b)
		{
			int[]tmp;
			tmp = a;
			a = b;
			b = tmp;
		}
		public static void ArrayElementSwap(ref int[] a,ref int[] b )
		{
			int tmp;
			for (int i = 0; i < a.Length; i++)
			{
				tmp =a[i];
				a[i]=b[i];
				b[i]=tmp;
			}
		}
		public static void ArraySwap(ref int[]a , ref int[]b)
		{
			Swap(ref a , ref b);

			// int w = a.Length;
			// int u = b.Length;
			// int bigger = a.Length;
			// int smaller = b.Length;
			// if (b.Length>bigger)
			// {
			// 	bigger = b.Length;
			// 	smaller = a.Length;
			// }
			// if (a.Length>b.Length)
			// {
			// Array.Resize<int>(ref b,a.Length);
			// }
			// else
			// {
			// 	Array.Resize<int>(ref a,b.Length);
			// }
			// int tmp;
			// for (int i = 0; i < a.Length; i++)
			// {
			// 	tmp =a[i];
			// 	a[i]=b[i];
			// 	b[i]=tmp;
			// }
			// if (w > u)
			// {
			// 	Array.Resize<int>(ref a ,u);
			// }
			// else
			// {
			// 	Array.Resize<int>(ref b,w);
			// }


		}
		public static int OddSum(int[] nums)
		{
			int sum = 0 ;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i]%2 == 1 )
				{
					sum = sum + nums[i];
				}
			}
			return sum;
		}

		public static void Swap<_Type>(ref _Type a, ref _Type b)
		{
			_Type tmp;
			tmp = a ;
			a = b;
			b = tmp;
		}
	}
	public class Human:  IHasAge
	{
		public Human(string n , int a)
		{
		Name = n; age = a;
		}

		public string Name;
		public int age;

        public int GetAge()
        {
            return age;
        }
    }
}
