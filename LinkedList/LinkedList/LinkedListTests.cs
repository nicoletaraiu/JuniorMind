using System;
using System.Linq;
using Xunit;

namespace LinkedList
{
    public class LinkedListTests
    {

        [Fact]
        public void AddTest()
        {
            var aList = new LinkedList<int> { 2, 5, 8, 7 };
            Assert.Equal(4, aList.Count);
            aList.Add(9);
            Assert.Equal(5, aList.Count);
        }

        [Fact]
        public void CountTest()
        {
            var aList = new LinkedList<int> { 2, 5, 8, 7 };
            Assert.Equal(4, aList.Count);
        }
    }
}
