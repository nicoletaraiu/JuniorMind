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
    }
}
