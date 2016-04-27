using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    class Candidate
    {
        private string name;
        private int noOfVotes;

        public Candidate(string name, int noOfVotes)
        {
            this.name = name;
            this.noOfVotes = noOfVotes; 
        }

        public int CompareByName(Candidate other)
        {
            if (name.Equals(other.name))
                return 0;
            if (name[0] < other.name[0])
                return 1;
            return -1;
        }

        public int CompareByVotes(Candidate other)
        {
            if (noOfVotes == other.noOfVotes)
                return 0;
            if (noOfVotes > other.noOfVotes)
                return 1;
            return -1;
        }
    }
}
