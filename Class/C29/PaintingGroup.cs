using System;
using System.Collections.Generic;
using System.Linq;

namespace C29
{

    // TODO: Make Reduce virtual in the base class and override here 
    // instead of taking Reduce as a delegate parameter in the constructor
    // class ProportionalCompositePainter: CompositePainter<ProportionalPainter>
    // {}

    class CompositePainter<TPainter>: IPainter
        where TPainter: IPainter
    {
        private IEnumerable<TPainter> painters {get; }

        public bool IsAvailable => this.painters.Any(p => p.IsAvailable);

        public CompositePainter(
            IEnumerable<TPainter> painters, 
            Func<double, IEnumerable<TPainter>, IPainter> reduce) 
        {
            this.painters = painters.ToList();
            this.Reduce = reduce;
        }

        private Func<double, IEnumerable<TPainter>, IPainter> Reduce;

        public double EstimateCompensation(double sqMeters) => 
            this.Reduce(sqMeters, this.painters).EstimateCompensation(sqMeters);

        public double EstimateTimeToPaint(double sqMeters) =>
            this.Reduce(sqMeters, this.painters).EstimateTimeToPaint(sqMeters);
    }
}