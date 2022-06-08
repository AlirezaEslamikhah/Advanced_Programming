using System.Collections.Generic;
using System.Linq;

namespace C29
{
    class Painters
    {
        private IEnumerable<IPainter> ContainedPainters;
        public Painters(IEnumerable<IPainter> painters)
        {
            ContainedPainters = painters.ToList();
        }

        public Painters GetAvailable() => new Painters(this.ContainedPainters.Where(p => p.IsAvailable));

        public IPainter GetCheapest(double sqMeters) =>
            this.ContainedPainters.WithMinimum(x => x.EstimateCompensation(sqMeters));

        public IPainter GetFastest(double sqMeter) => 
            this.ContainedPainters.WithMinimum(x => x.EstimateTimeToPaint(sqMeter));


    }
}