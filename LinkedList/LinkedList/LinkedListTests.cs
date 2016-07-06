using System;
using System.Linq;
using Xunit;

namespace LinkedList
{
    public class LinkedListTests
    {
        [Fact]
        public void CountTest()
        {
            var aList = new LinkedList<int> { 2, 5, 8, 7 };
            Assert.Equal(4, aList.Count);
        }
    }
}
