using System;
using System.IO;

namespace Calculator
{
    public class NumberExpression : Expression
    {
        protected double Number;

        public NumberExpression(string line)
        {
            throw new NotImplementedException();
        }

        public override double Evaluate() => throw new NotImplementedException();

        public override string ToString() => throw new NotImplementedException();
    }
}