using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    class CandidatesSortedByVotes
    {
        private Candidate[] candidates;
        public CandidatesSortedByVotes(Candidate[] candidates)
        {
            this.candidates = candidates;
        }

        public Candidate[] SortByVotes(Candidate[] candidates)
        {
            for (int i = 0; i < candidates.Length; i++)
                for (int j = 0; j < candidates.Length - 1; j++)
                {
                    if (candidates[j].CompareByVotes(candidates[j + 1]) == -1)
                    {
                        Candidate aux = candidates[j];
                        candidates[j] = candidates[j + 1];
                        candidates[j + 1] = aux;
                    }
                }
            return candidates;
        }



    }
}
