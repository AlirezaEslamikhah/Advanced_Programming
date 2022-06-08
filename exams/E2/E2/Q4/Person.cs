using System;
using System.Collections.Generic;

namespace E2.Q4
{
    public class Person: IVoter
    {
        public static void ResetRndGen() => GeneSeedGenerator = new Random(1);
        protected static Random GeneSeedGenerator = new Random(1);
        const double YesThreshold = 0.3;
        const double NoThreshold = 0.6;
        protected Random Gene = new Random(GeneSeedGenerator.Next());
        public string Name { get;  }
        public uint Id { get; }
        public Person(string name, uint id)
        {
            this.Name = name;
            this.Id = id;
        }
        /// <summary>
        /// generating random vote for a person
        /// </summary>
        /// <param name="issue"></param>
        /// <returns>a voteresult data type which has white count, no count and yes count properties</returns>
        
        public static int y;
        public static int n;
        public static int w;
        public static int t;


        public VoteResult Vote(string issue)
        {
            int yesCount = 0, noCount=0, whiteCount=0;
            double d = Gene.NextDouble();
            if (d > NoThreshold)
            {
                whiteCount++;
                w++;
                t++;
            }
            else if (d > YesThreshold)
            {
                noCount++;
                n++;
                t++;
            }
            else
            {
                yesCount++;
                y++;
                t++;
            }
            return new VoteResult(issue, yesCount, noCount, whiteCount);
        }
    }
}