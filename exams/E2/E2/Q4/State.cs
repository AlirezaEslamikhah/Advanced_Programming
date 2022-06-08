using System;
using System.Linq;

namespace E2.Q4
{
    public class State : IVoter
    {
        public State(string name, City[] city)
        {
        }
        /// <summary>
        /// generating vote result for a state by summing all the vote results of the cities located in  this state
        /// and calling each city's vote function
        /// </summary>
        public VoteResult Vote(string issue) => throw new NotImplementedException();
    }
}