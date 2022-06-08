using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;

namespace A7
{
    public class ExceptionHandler
    {
        public string ErrorMsg { get; set; }
        public readonly bool DoNotThrow;
        private string _Input;

        public string Input
        {
            get
            {
                try
                {
                    if (_Input.Length < 50)
                        return _Input;
                        // throw new NullReferenceException();
                }
                catch
                {
                    if (!DoNotThrow)
                        throw;
                    ErrorMsg = "Caught exception in GetMethod";
                }
                return null;
            }
            set
            {
                try
                {
                    if (value.Length < 50)
                        _Input = value;
                }
                catch
                {
                    if (!DoNotThrow)
                        throw;
                    ErrorMsg = "Caught exception in SetMethod";
                }
            }
        }


        public ExceptionHandler(
            string input,
            bool causeExceptionInConstructor,
            bool doNotThrow=false)
        {
            DoNotThrow = doNotThrow;
            this._Input = input;
            try
            {
                if (causeExceptionInConstructor)
                {
                    string test = null;
                    if (test.Length > 0)
                        Console.WriteLine("test");
                }
            }
            catch
            {
                if (!DoNotThrow)
                    throw;
                ErrorMsg = "Caught exception in constructor";
            }
        }

        
        public void OverflowExceptionMethod()
        {
            checked
            {
                try
                {
                    int mul = 1 ;
                    int w = int.Parse(Input);
                    if (w == int.MaxValue )
                    {
                        
                        for (int i = 1; i < 100000; i++)
                        {
                            mul = mul * i;
                        }
                    }
                    if(w != int.MaxValue)
                    {
                        System.Console.WriteLine("a");
                    }
                }
            
            
                catch (OverflowException a )
                {
                    if (!DoNotThrow)
                    {
                        throw;
                    }
                    else
                    {
                        ErrorMsg = $"Caught exception {a.GetType()}";
                    }
                }
            }
        }

        

        public void FormatExceptionMethod()
        {
            try
            {
                int i = int.Parse(Input);
            }
            catch(FormatException e)
            {
                if (!DoNotThrow)
                    throw;
                ErrorMsg = $"Caught exception {e.GetType()}";
            }
        }

        public void FileNotFoundExceptionMethod()
        {
            try
            {
                int w = int.Parse(Input);
                if (w == int.MaxValue )
                {
                    using (StreamReader reader = new StreamReader("b.txt"))
                    {
                        
                    }
                }
                if(w != int.MaxValue)
                {
                    bool ifexists = File.Exists("a7.pdf");
                }
            }
            catch (FileNotFoundException a )
            {
                if (!DoNotThrow)
                {
                    throw;
                }
                else
                {
                    ErrorMsg = $"Caught exception {a.GetType()}";
                }
            }
        }

        public void IndexOutOfRangeExceptionMethod()
        {
            try
            {
                int[] p = new int[1];
                if (int.Parse(Input)==0)
                {
                    p[0] = 4;
                }
                if (int.Parse(Input)==1)
                {
                    p[1] = 4;
                }
            }
            catch (IndexOutOfRangeException e)
            {
                if (!DoNotThrow)
                {
                    throw;
                }
                else
                {
                    ErrorMsg = $"Caught exception {e.GetType()}";
                }
            }
        }

        public void OutOfMemoryExceptionMethod()
        {
            try
            {
                List<int> a = new List<int>();
                
                int w = int.Parse(Input);
                if (w == int.MaxValue )
                {
                    for (int i = 0; i < 100; i++)
                    {
                        int[]b = new int[int.MaxValue];
                    }
                }
                if(w != int.MaxValue)
                {
                    a.Add(5);
                }
            }
            catch (OutOfMemoryException a )
            {
                if (!DoNotThrow)
                {
                    throw;
                }
                else
                {
                    ErrorMsg = $"Caught exception {a.GetType()}";
                }
            }
        }

        public void MultiExceptionMethod()
        {
            try
            {
                int w = int.Parse(Input);
                if (w == 0)
                {
                    System.Console.WriteLine("w");
                }
                if (w == int.MaxValue && DoNotThrow == false)
                {
                    int[] a = new int[int.MaxValue];
                }
                if (w == 1 && DoNotThrow == false)
                {
                    int[] a = new int[int.MaxValue];
                }
                if (w == int.MaxValue && DoNotThrow == true)
                {
                    int[] a = new int[int.MaxValue];
                }
                if (w == 1 && DoNotThrow == true)
                {
                    int[] c = new int[10];
                    c[20] = 30;
                }

            }
            catch (OutOfMemoryException a )
            {
                int w = int.Parse(Input);
                if (w == int.MaxValue && DoNotThrow == false)
                {
                    ErrorMsg = $"Caught exception {a.GetType()}";
                    throw;
                }
                if (w == int.MaxValue && DoNotThrow == true)
                {
                    ErrorMsg = $"Caught exception {a.GetType()}";
                }
                if (w == 1 )
                {
                    ErrorMsg = $"Caught exception {a.GetType()}";
                    throw new IndexOutOfRangeException();
                }
            }
            catch(IndexOutOfRangeException a )
            {
                int w = int.Parse(Input);

                if (w == 1 )
                {
                    ErrorMsg = $"Caught exception {a.GetType()}";
                }
            }
        }

        public static void ThrowIfOdd(int n)
        {
            if (n%2==1)
            {
                throw new InvalidDataException();
            }
        }

        public string FinallyBlockStringOut;

        public void FinallyBlockMethod(string s)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter swr = new StringWriter(sb);
            try
            {
                if (s == "beautiful")
                {
                    swr.Write("InTryBlock:"+s+":9"+":DoneWriting");
                }
                if (s == "ugly")
                {
                    int[] a = null;
                    a[1] = 2;
                }
                if (s == null)
                {
                    int[] a = null;
                    a[1] = 2;
                }
            }
            catch (NullReferenceException nre)
            {
                if (DoNotThrow)
                {
                    swr.Write("InTryBlock::");
                    swr.Write($"{nre.Message}");
                    
                }
                if(s == "ugly")
                {
                    swr.Write("InTryBlock:");
                    return;
                }
                if (s == null && DoNotThrow == false)
                {
                    swr.Write("InTryBlock::");
                    swr.Write($"{nre.Message}");
                    throw new NullReferenceException();
                    
                }
                
            }
            finally
            {
                swr.Write(":InFinallyBlock");
                swr.Dispose();
                FinallyBlockStringOut = sb.ToString();
                
            }
            FinallyBlockStringOut += ":EndOfMethod";
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void NestedMethods()
        {
            MethodA();
        }

        private static void MethodA()
        {
            MethodB();
        }

        private static void MethodB()
        {
            MethodC();
        }

        private static void MethodC()
        {
            MethodD();
        }

        private static void MethodD()
        {
            throw new NotImplementedException();
        }
    }
}
