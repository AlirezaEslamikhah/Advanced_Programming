using static System.Console;

namespace A8.StatePattern
{
    public class AccumulateState : CalculatorState
    {
        public AccumulateState(Calculator calc) : base(calc) { }

        // #7 لطفا
        public override IState EnterEqual()
        {
            return ProcessOperator(new ComputeState(this.Calc));
        }
        public override IState EnterZeroDigit() => EnterNonZeroDigit('0');
        public override IState EnterNonZeroDigit(char c)
        {
            this.Calc.Display += c;
            // #8 لطفا!
            //خب با توجه به خط 14 ما میاییم چیزی که مانیتور ماشین حساب نشان میدهد را پلاس مساوی میکنیم چون اگر مساوی کنیم تمام چیزهای قبلی پاک میشوند 
            //برای خط 18 هم با توجه به کمکی که در فایل استارت استیت به ما شد من این را ریترن کردم ولی سپس متوجه شدم که دلیل این کار اینست که با توجه به بیس کانستراکتور این کلاس چیزی که در ورودی کانستراکتور میدهیم وارد کلاس ماشین حساب میشود 
            // return new AccumulateState(this.Calc);
            return this;
        }

        // #9 لطفا!
        public override IState EnterOperator(char c) 
        {
            return ProcessOperator(new ComputeState (this.Calc),c);
            // return new ComputeState(this.Calc);
        }

        public override IState EnterPoint()
        {
            // #10 لطفا!
            this.Calc.Display += ".";
            return new PointState(this.Calc);
            // return null;
        }
    }
}