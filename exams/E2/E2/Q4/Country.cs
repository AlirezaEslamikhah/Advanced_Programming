using System;
using System.Linq;

namespace E2.Q4
{
    public class Country : IVoter
    {
        public Country(string name, State[] states)
        {
        }
        /// <summary>
        /// generating vote result for the entire country by summing all the vote results of the states located in  the country
        /// and caaling each state's vote function which itself calls the located cities' vote function and so on (call hierarchy)
        /// </summary>
        /// <param name="issue"></param>
        public VoteResult Vote(string issue) => throw new NotImplementedException();
    }
}