using System;
using System.Linq;

namespace E2.Q4
{
    public class City : IVoter
    {
        const double YesThreshold = 0.3;
        const double NoThreshold = 0.6;
        public static void ResetRndGen() => GeneSeedGenerator = new Random(1);
        protected static Random GeneSeedGenerator = new Random(1);
        protected Random Gene = new Random(GeneSeedGenerator.Next());
        public string _name;
        public Person[] rayat;
        public City(string name, Person[] people)
        {
            _name = name;
            rayat = people;
        }
        /// <summary>
        /// shows the entire vote result of a city by calculating the sum of all people's vote who live in this city
        /// by calling each person's vote function
        /// </summary>
        // public VoteResult c = new VoteResult();
        public VoteResult Vote(string issue) 
        {
            // int yesCount = 0, noCount=0, whiteCount=0;
            // double d = Gene.NextDouble();
            // if (d > NoThreshold)
            // {
            //     whiteCount++;
            // }
            // else if (d > YesThreshold)
            // {
            //     noCount++;
                
            // }
            // else
            // {
            //     yesCount++;
                
            // }
            // return new VoteResult(issue, yesCount, noCount, whiteCount);
            return new VoteResult(issue,Person.y,Person.n,Person.w);

        }
    }
}