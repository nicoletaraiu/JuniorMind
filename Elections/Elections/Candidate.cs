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

        Candidate(string name, int noOfVotes)
        {
            this.name = name;
            this.noOfVotes = noOfVotes; 
        }
    }
}
