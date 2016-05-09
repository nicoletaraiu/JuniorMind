using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    class CandidatesSortedAlphabetically
    {
        private Candidate[] candidates;
        public CandidatesSortedAlphabetically(Candidate[] candidates)
        {
            this.candidates = candidates;
        }
      
        public Candidate[] SortAlphabetically(Candidate[] candidates, int begin, int end)
        {
            Candidate pivot = candidates[(begin + (end - begin) / 2)];
            int left = begin;
            int right = end;
            while (left <= right)
            {
                while (candidates[left].CompareByName(pivot) == 1)
                {
                    left++;
                }
                while (candidates[right].CompareByName(pivot) == -1)
                {
                    right--;
                }
                if (left <= right)
                {
                    swap(candidates, left, right);
                    left++;
                    right--;
                }
                if (begin < right)
                {
                    return SortAlphabetically(candidates, begin, left - 1);
                }
                if (end > left)
                {
                    return SortAlphabetically(candidates, right + 1, end);
                }

            }
            return candidates;

        }
        static void swap(Candidate[] candidates, int x, int y)
        {
            Candidate temp = candidates[x];
            candidates[x] = candidates[y];
            candidates[y] = temp;
        }

    }
}
