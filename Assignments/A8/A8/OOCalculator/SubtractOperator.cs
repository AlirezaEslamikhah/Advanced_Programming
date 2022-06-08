using System;
using System.IO;

namespace A8.OOCalculator
{
    public class SubtractOperator : BinaryOperator
    {
        public SubtractOperator(TextReader reader)
        :base(reader)
        {
            
        }

        public override string OperatorSymbol => "-";

        public override double Evaluate()
        {
            double a = LHS.Evaluate();
            double b = RHS.Evaluate();
            return a-b;
        }
    }
}