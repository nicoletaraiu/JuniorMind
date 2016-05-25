using List;
using System;
using System.Linq;
using Xunit;

namespace ListTests
{
    public class ListTests
    {
        [Fact]
        public void AddAndCountTest()
        {
            var firstList = new List<int>();
            firstList.Add(13);
            firstList.Add(100);
            Assert.Equal(2, firstList.Count);
        }

        [Fact]
        public void ClearTest()
        {
            var list = new List<int>();
            list.Add(20);
            list.Add(1);
            list.Clear();
            Assert.Equal(0, list.Count);
        }

        [Fact]
        public void IndexOfTest()
        {
            var list = new List<int>();
            list.Add(20);
            list.Add(11);
            list.Add(5);
            Assert.Equal(1, list.IndexOf(11));
        }

        [Fact]
        public void InsertTest()
        {
            var list = new List<int> { 12, 20, 11, 13 };
            list.Insert(2, 22);
            Assert.Equal(2, list.IndexOf(22));
        }

        [Fact]
        public void RemoveAtTest()
        {
            var list = new List<int> { 12, 20, 11, 13 };
            list.RemoveAt(2);
            Assert.Equal(2, list.IndexOf(13));
            
        }
        [Fact]
        public void ContainsTest()
        {
            var list = new List<int> { 12, 20, 11, 13 };
            
            Assert.Equal(true, list.Contains(20));
            Assert.Equal(false, list.Contains(3));

        }

        [Fact]
        public void CopyToTest()
        {
            var arr = new int[] { 12, 20, 11, 13, 25, 18, 9 };
            var list = new List<int> { 1, 2, 3 };
            list.CopyTo(arr, 2);

            Assert.Equal(new int[] {12, 20, 1, 2, 3, 18, 9 }, arr);

        }
    }
}
