using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    class FinalList
    {
        CandidatesSortedAlphabetically[] lists;
        int numberOfLists;
        public FinalList(int numberOfLists, CandidatesSortedAlphabetically[] lists)
        {
            this.lists = lists;
            this.numberOfLists = numberOfLists;
        } 

        public CandidatesSortedAlphabetically MergeLists(CandidatesSortedAlphabetically[] lists)
        {
            CandidatesSortedAlphabetically finalList = lists[0];
            
                for(int j = 1; j < numberOfLists; j++)
                
                finalList.Merge(lists[j]);
                
            return finalList;

        }

    }
   }

