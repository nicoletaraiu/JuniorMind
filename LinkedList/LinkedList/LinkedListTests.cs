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

        [Fact]
        public void TestforContain()
        {
            var aList = new LinkedList<int> { 2, 5, 8, 7 };
            Assert.True(aList.Contains(5));
            Assert.False(aList.Contains(12));
        }

        [Fact]
        public void TestforCopy()
        {
            var aList = new LinkedList<int> { 2, 5, 8, 7 };
            int[] arr = { 1, 2, 3, 4, 5 };
            aList.CopyTo(arr, 2);
            Assert.Equal(new int[] { 1, 2, 2, 5, 8 }, arr);
        }

        [Fact]
        public void TestforRemove()
        {
            var aList = new LinkedList<int> { 2, 5, 8, 7 };
            Assert.True(aList.Remove(8));
            Assert.Equal(3, aList.Count);
            Assert.False(aList.Remove(3));

        }

        [Fact]
        public void TestforIndexOf()
        {
            var aList = new LinkedList<int> { 2, 5, 8, 7 };
            Assert.Equal(1, aList.IndexOf(5));
            Assert.Equal(-1, aList.IndexOf(12));
        }


        [Fact]
        public void TestforRemoveAt()
        {
            var aList = new LinkedList<int> { 2, 5, 8, 7 };
            aList.RemoveAt(1);
            int[] arr = new int[3];
            aList.CopyTo(arr, 0);
            Assert.Equal(new int[] { 2, 8, 7 }, arr);
        }

    }
}
