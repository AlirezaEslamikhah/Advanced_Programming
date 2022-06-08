using System;

namespace E1
{
    public struct DoubleWithOp :
        ICalculable<DoubleWithOp>, IEquatable<DoubleWithOp>
    {
        // private double v;

        public DoubleWithOp(double v)
        {
            this.Value = v;
        }

        public DoubleWithOp PlusIdentity => new DoubleWithOp(+1);

        public DoubleWithOp NegIdentity => new DoubleWithOp(-1);

        public double Value { get; set; }

        public DoubleWithOp AddWith(DoubleWithOp other)
        {
            DoubleWithOp w = new DoubleWithOp();
            w.Value = this.Value + other.Value;
            return w;
        }

        public DoubleWithOp Clone()
        {
            DoubleWithOp w = new DoubleWithOp();
            w.Value = this.Value;
            return w;
        }

        public bool Equals(DoubleWithOp other)
        {
            return(other.Value == this.Value);
        }

        public void LoadFromStr(string str)
        {
            this.Value = double.Parse(str);
        }

        public DoubleWithOp MultiplyBy(DoubleWithOp other)
        {
            DoubleWithOp w = new DoubleWithOp();
            w.Value = this.Value * other.Value;
            return w;
        }
        public override string ToString()
        {
            return this.Value.ToString();
        }

        public void Reset()
        {
            this.Value = 0;
        }
        public void yeke()
        {
            this.Value = 1;
        }
        private static Random Rnd = new Random(0);
        public void RndSet()
        {
            
            this.Value = Rnd.Next();
        }

        public void Set(DoubleWithOp o)
        {
            this.Value = o.Value;
        }
    }
}
