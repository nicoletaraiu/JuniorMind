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
        ListOfCandidates(int noOfLists, Candidate[] candidates)
        {
            this.noOfLists = noOfLists;
            this.candidates = candidates;
        }

       private Candidate[] OrderAlphabelically(Candidate[] candidates)
        {
            for (int i = 1; i < candidates.Length; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (candidates[j - 1].name >candidates[j].name)
                    {
                        int temp = candidates[j - 1].name;
                        candidates[j - 1].name = candidates[j].name;
                        candidates[j].name = temp;
                        j--;
                    }
                    else
                        break;
                }
                return candidates; 
            }
    }
}
