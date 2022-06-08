using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E1
{
    public class Matrix<_Type> :
        ICalculable<Matrix<_Type>>,
        IEquatable<Matrix<_Type>>
        where
            _Type : ICalculable<_Type>, IEquatable<_Type>
    {
        private _Type[,] Data;
        private int v1;

        public void SetData(int v1, int v2, _Type d)
        {
            // d = default;
            // Data = default;
            this.Data[v1,v2] = d;
        }

        private int v2;

        public Matrix(int v1, int v2)
        {
            this.RowCount = v1;
            // this.Data[,] = this.RowCount;
            this.ColumnCount = v2;
            Data = new _Type [RowCount,ColumnCount]; 
            // _Type [,] Data = default;
            // _Type[,] Data = new _Type[v1,v2];
            // _Type Data = default;
            // _Type Data = default;
        }

        public Matrix<_Type> PlusIdentity => akbar();

        private Matrix<_Type> akbar()
        {
            Matrix<_Type> d = new Matrix<_Type>(RowCount,ColumnCount);
            for (int i = 0; i < this.RowCount; i++)
            {
                for (int j = 0; j < this.ColumnCount; j++)
                {
                    if (i == j)
                    {
                        d.Data[i,j].init(1);
                    }
                    else
                    {
                        d.Data[i,j].Reset(); 
                    }
                }
            }
            return d;
        }
        // private _Type uv =(_Type) x ;
        // private static int x = 1;
        public _Type GetData(int v1, int v2)
        {
            return Data[v1,v2];
        }

        public Matrix<_Type> NegIdentity => throw new NotImplementedException();

        public int RowCount { get; set; }
        public int ColumnCount { get; set; }
        public IEnumerable<_Type> Rows { get; set; }

        public Matrix<_Type> AddWith(Matrix<_Type> other)
        {
            Matrix<_Type> d = new Matrix<_Type>(other.RowCount,other.ColumnCount);
            for (int i = 0; i < other.RowCount; i++)
            {
                for (int j = 0; j < other.ColumnCount; j++)
                {
                    d.Data[i,j] = other.Data[i,j].AddWith(this.Data[i,j]);
                }
            }
            return d;
        }
        
        

        public Matrix<_Type> Clone()
        {
            Matrix<_Type> d = new Matrix<_Type>(this.RowCount,this.ColumnCount);
            d.Data = new _Type [this.RowCount ,this.ColumnCount];
            for (int j = 0; j < this.RowCount; j++)
            {
                for (int i = 0; i < this.ColumnCount; i++)
                {
                    d.Data[j,i] = this.Data[j,i];
                }
            }
            return d;
        }

        public bool Equals(Matrix<_Type> other)
        {
            int q = 0;
            for (int i = 0; i < other.RowCount; i++)
            {
                for (int j = 0; j < other.ColumnCount; j++)
                {
                    // if(other.Data[i,j] == this.Data[i,j])
                    if(other.Data[i,j].Equals(this.Data[i,j]))
                        q = 1;
                    else
                        q =0;
                }
            }
            if (q == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LoadFromStr(string str)
        {
            
        }

        public Matrix<_Type> MultiplyBy(Matrix<_Type> other)
        {
            Matrix<_Type> d = new Matrix<_Type>(other.RowCount,other.ColumnCount);
            for (int j = 0; j < other.RowCount; j++)
            {
                for (int i = 0; i < other.ColumnCount; i++)
                {
                    
                    d.Data[i,j] = this.Data[j,i].MultiplyBy(other.Data[i,j]);
                }
            }
            return d;
        }
        public override string ToString()
        {
            string v = $"{this.RowCount} {this.ColumnCount}\n";
            string w="";
            int j =0;
            for (int i = 0; i < this.RowCount; i++)
            {
                if (this.ColumnCount == 2)
                {
                    w+= $"{ this.Data[i,j]} {this.Data[i,j+1]}\n";
                }
                if (this.ColumnCount == 3)
                {
                    w+= $"{ this.Data[i,j]} {this.Data[i,j+1]} {this.Data[i,j+2]}\n";
                }
            }
            return v+w;
        }

        // public static string operator +(string p1, string p2 , string p3) => p1 + p2 + p3;

        public void Reset()
        {
            for (int i = 0; i < this.RowCount; i++)
            {
                for (int j = 0; j < this.ColumnCount; j++)
                {
                    this.Data[i,j].Reset();
                }
            }
        }
        private static Random Rnd = new Random(0);
        

        public void RndSet()
        {
            for (int i = 0; i < this.RowCount; i++)
            {
                
                for (int j = 0; j < this.ColumnCount; j++)
                {
                    this.Data[i,j].RndSet();
                }
            }
        }

        public void Set(Matrix<_Type> o)
        {
            throw new NotImplementedException();
        }

        public void init(int v)
        {
            this.Data.SetValue(1);
        }
    }
}
