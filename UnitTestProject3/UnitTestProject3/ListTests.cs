using List;
using System;
using System.Linq;
using Xunit;

namespace UnitTestProject3
{
    public class UnitTest1
    {
        [Fact]
        public void AddAndCountTest()
        {
            var firstList = new List<int>();
            firstList.Add(13);
            firstList.Add(100);
            Assert.Equal(2, firstList.Count);
        }
    }
}
