using System;
using System.Collections.Generic;

namespace C14
{
    class Program
    {
        #region  Hide
        static int add(int a, int b) => a + b;
        static _T[] Perform<_T>(_T[] a, _T[] b, Func<_T,_T,_T> op)
        {
            _T[] c = new _T[a.Length];
            for(int i=0; i<a.Length; i++)
                c[i] = op(a[i], b[i]);
            return c;
        }

        static void do1(int a)
        {}

        static Random rnd = new Random();

        // Func<int>
        static int get_random()
        {
            return rnd.Next();
        }

        static void PrintRndNums(int count, Func<int> rndGen)
        {
            for(int i=0; i<count; i++)
            {
                int rnd = rndGen();
                System.Console.WriteLine(rnd);
            }                
        }

        static void Do(int[] nums, Action<int> action)
        {
            foreach(var n in nums)
                action(n);
        }

        // delegate void MyAction(int a, int b);
        static void Print(int i) 
        {
            System.Console.WriteLine(i);
        } 
        #endregion        
        
        static void Test()
        {
            System.Console.WriteLine("In Test");
        }

        // delegate int MyDelegate(int a, int b);
        // static int myop(int a, int b) => a + b;

        static void TestAction(int[] nums, 
            Func<int, int>[] op,
            Func<bool>[] iff,
            Action<int>[] dof)
        {
            
        }
        // update nums[i] with op and if (iff is true for nums[i]) action dof nums[i]
            // if nums[i] % 4 = 0 , + 5
            // if nums[i] % 4 = 1 , * 5
            // if nums[i] % 4 = 2 , - 5
            // if nums[i] % 4 = 3 , / 5
            // if nums[i] % 2 == 0, cw, red
            // if nums[i] % 2 == 1, cw, blue
            //Console.ForegroundColor = ConsoleColor.Red

        static void Main(string[] args)
        {
            
            int[] n = new int[]{2,3,5,12,3,2,7};
            
            Func<int,int>[] a = new Func<int,int>[n.Length];
            Func<bool>[] b = new Func<bool>[n.Length];
            Action<int>[] c = new Action<int>[n.Length];

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i]%4 == 0)
                    a[i] = (x)=>x+5;
                else if (n[i]%4 ==1 )
                {
                    a[i] = (x)=>x*5;
                }
                else if (n[i] %4 == 2)
                {
                    a[i] = (x)=>x-5;
                }
                else 
                {
                    a[i] = (x)=>x/5;
                }
                b[i] = ()=>true;
                if (i%2 == 0)
                {
                    c[i] = (x) =>{Console.ForegroundColor = ConsoleColor.Red
                    ;
                    System.Console.WriteLine(x);};
                }
                else
                {
                    c[i] = (x) =>{Console.ForegroundColor = ConsoleColor.Blue;                    
                    System.Console.WriteLine(x);};
                }
            }



            // List<Func<bool>> iffList = new List<Func<bool>>();
            // int iff_counter = 0;
            // for (int i=0; i<10; i++)
            // {
            //     Func<bool> iffa = () => {
            //         bool returnValue = iff_counter % 2 == 0;
            //         iff_counter++;
            //         return returnValue;
            //     };
            // }
            // TestAction(, , iffList, ..)

            // List<MyDelegate> testList = new List<MyDelegate>();
            // testList.Add(myop);

            // List<Action> funcs = new List<Action>();
            // funcs.Add(Test);
            // for(int i=0; i<10; i++)
            // {
            //     Action a = () => 
            //     {
            //         System.Console.WriteLine(i);
            //         i++;
            //     };
            //     funcs.Add(a);
            //     a();

            // }

            // foreach(var fn in funcs)
            //     fn();
        }

        static void Main1(string[] args)
        {
            int[] l1 = new int[] {1,2,3,4};
            int[] l2 = new int[] {3,4,1,2};
            int[] l3 = Perform<int>(l1, l2, (k,s) => k+s);

            int c = 10;

            Action<int> myAction = (a) => {
                for(int i=0; i<a; i++)
                    System.Console.WriteLine(a+c);
                System.Console.WriteLine("Done");
            };

            myAction(5);
            Do(l1, myAction);

            Do(l1, (a) => {
                for(int i=0; i<a; i++)
                    System.Console.WriteLine(a);
                System.Console.WriteLine("Done");
            });
            // Do(l1, Print);

            Console.WriteLine("Hello World!");
        }
    }
}
