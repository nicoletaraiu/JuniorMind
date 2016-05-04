using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    class Sort
    {
        private Candidate[] candidates;
        public Sort(Candidate[] candidates)
        {
            this.candidates = candidates;
        }
        public Candidate[] SortAlphabetically()
        {
            for (int i = 1; i < candidates.Length; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (candidates[j - 1].CompareByName(candidates[j]) == -1)
                    {
                        Candidate temp = candidates[j - 1];
                        candidates[j - 1] = candidates[j];
                        candidates[j] = temp;
                        j--;
                    }
                    else
                        break;
                }

            }
            return candidates;
        }
    }
}
