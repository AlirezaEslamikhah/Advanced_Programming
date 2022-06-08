using System;
using System.IO;

namespace Calculator
{
    public class MultiplyOperator : BinaryOperator
    {
        public string[]b;
        public MultiplyOperator(TextReader reader)
        // :base{}
        {
            string a = reader.ReadLine();
            b = a.Split("\n");
        }

        

        public override string OperatorSymbol => throw new NotImplementedException();

        public override double Evaluate() => int.Parse(b[1])*int.Parse(b[0]);
    }
}