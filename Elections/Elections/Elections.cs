using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    class Elections 
    {
        private Candidate[] ListsOfCandidates;

        public Candidate [] getLists()
        {
            return ListsOfCandidates;
        }

        public void setLists(Candidate [] Lists)
        {
            ListsOfCandidates = Lists; 
        }
        
       
    }

    public struct Candidate
    {
        string [] names ;
        int [] noOfVotes;

        public Candidate(string [] names, int [] noOfVotes)
        {
            this.names = names;
            this.noOfVotes = noOfVotes;
        }
    }
}
