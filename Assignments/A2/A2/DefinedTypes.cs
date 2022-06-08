using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace A2
{
    public struct TypeOfSize5
    {
        char a;
        char b;
        char c;
        char d;
        char e;
    }
    public struct TypeOfSize22
    {
        TypeOfSize5 a;
        TypeOfSize5 b;
        TypeOfSize5 c;
        TypeOfSize5 d;
        char s;
        char r;
    }
    public struct TypeOfSize125
    {
        TypeOfSize22 a;
        TypeOfSize22 b;
        TypeOfSize22 c;
        TypeOfSize22 d;
        TypeOfSize22 e;
        TypeOfSize5 f;
        TypeOfSize5 h;
        // TypeOfSize5 j;
        // TypeOfSize5 w;
        char y;
        char o;
        byte u;
        byte p;
        byte q;
    }
    public struct TypeOfSize1024
    {
        TypeOfSize125 a; 
        TypeOfSize125 b;
        TypeOfSize125 c;
        TypeOfSize125 d;
        TypeOfSize125 e;
        TypeOfSize125 f;
        TypeOfSize125 q;
        TypeOfSize125 o;
        TypeOfSize22 u;
        char w;
        char z;
    }
    public struct n
    {
        TypeOfSize1024 a;
        TypeOfSize1024 b;
        TypeOfSize1024 c;
        TypeOfSize1024 d;
        TypeOfSize1024 e;
        TypeOfSize1024 t;
        TypeOfSize1024 f;
        TypeOfSize1024 g;
    }
    public struct TypeOfSize32768
    {
        n a;
        n b;
        n c; 
        n d;
    }
    public struct TypeForMaxStackOfDepth10
    {
        TypeOfSize32768 a;
        TypeOfSize1024 b;
        TypeOfSize1024 c;
        n f;
        n j;
        TypeOfSize1024 h;
    }
    public struct TypeForMaxStackOfDepth100
    {
        TypeOfSize1024 g;
        TypeOfSize1024 d;
        TypeOfSize1024 s;
        TypeOfSize1024 r;
        TypeOfSize1024 h;
        TypeOfSize1024 w;
        TypeOfSize1024 k;
    }
    public struct TypeForMaxStackOfDepth1000 
    {
        TypeOfSize125 k;
        TypeOfSize125 h;
        TypeOfSize125 G;
        TypeOfSize125 u;
        TypeOfSize125 y;
    }
    public struct TypeForMaxStackOfDepth3000
    {
        TypeOfSize125 a;
        TypeOfSize22 b;
        TypeOfSize22 c;
        TypeOfSize22 s;
    }
    public struct TypeWithMemoryOnHeap
    {
        private int[]x;
        public void Allocate()
        {
            x = new int[1000000];
        }
        public void DeAllocate()
        {
            x = null;
        }
    }
    public struct StructOrClass1
    {
        public int X;
    }
    public class StructOrClass2 
    {
        public int X;
    }

    public class StructOrClass3
    {
        public StructOrClass2 X;
    }
    public enum FutureHusbandType :int
        {
            
            None = 1,
            HasBigNose = 1<<1,
            IsBald = 1<<2,
            IsShort = 1<<3
        }
}