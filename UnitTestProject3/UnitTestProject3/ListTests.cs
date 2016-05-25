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
    }
}
