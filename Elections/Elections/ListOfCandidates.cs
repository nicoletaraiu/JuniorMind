using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    class ListOfCandidates
    {
        int noOfLists;
        Candidate[] candidates;
        public ListOfCandidates(int noOfLists, Candidate[] candidates)
        {
            this.noOfLists = noOfLists;
            this.candidates = candidates;
        }

    }
   }

