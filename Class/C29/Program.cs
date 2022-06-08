using System.Linq;

namespace C29
{
    class Program
    {
        static IPainter FindCheapest(Painters painters, double sqmt) =>
            painters.GetAvailable().GetCheapest(sqmt);

        static IPainter FindFastest(Painters painters, double sqmt) =>
            painters.GetAvailable().GetFastest(sqmt);


        static void Main(string[] args)
        {
            IPainter[] painters = new IPainter[]{
                new HandPainter(),            
                new MachinePainter()
            };
            ProportionalPainter[] pps = new ProportionalPainter[] {
                new ProportionalPainter() { DollarPerHour=2.2, TimePerSqMeter = 3.4},
                new ProportionalPainter() { DollarPerHour=2.5, TimePerSqMeter = 3.5},
            };

            var group = CompositePainterFactories.CreateCompositePainterGroup(pps);

            var p = group.EstimateCompensation(25);


            var painters1 = new Painters(painters); 

            IPainter chosen = FindCheapest(painters1, 25);

        }
    }
}