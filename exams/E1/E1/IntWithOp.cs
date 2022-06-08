using System;

namespace E1
{
    public struct IntWithOp : ICalculable<IntWithOp>, IEquatable<IntWithOp>
    {
        private static Random Rnd = new Random(0);
        private int v;

        public IntWithOp(int v) : this()
        {
            this.Value = v;
        }

        public int Value {get; private set;}

        public IntWithOp PlusIdentity => new IntWithOp(+1);

        public IntWithOp NegIdentity => new IntWithOp(-1);

        public IntWithOp AddWith(IntWithOp other)
        {
            IntWithOp w = new IntWithOp();
            w.Value = this.Value + other.Value;
            return w;
        }

        public IntWithOp Clone()
        {
            IntWithOp w = new IntWithOp();
            w.Value = this.Value;
            return w;
        }

        public bool Equals(IntWithOp other)
        {
            return(other.Value == this.Value);
        }

        public void LoadFromStr(string str)
        {
            this.Value = int.Parse(str);
        }

        public IntWithOp MultiplyBy(IntWithOp other)
        {
            IntWithOp w = new IntWithOp();
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

        public void RndSet()
        {
            this.Value = Rnd.Next();
        }

        public void Set(IntWithOp o)
        {
            this.Value = o.Value;
        }
    }
}
