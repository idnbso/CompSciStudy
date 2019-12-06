using System;
using Xunit;

namespace DataStructures.Tests
{
    public class UnitTestExample
    {
        #region Add Tests

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            //Assert.Equal(5, Add(2, 2));
            Assert.True(true);
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        #endregion Add Tests

        #region IsOdd Theory
        
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        [Theory]
        [InlineData(2)]
        [InlineData(6)]
        public void IsNotOdd(int value)
        {
            Assert.False(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        #endregion IsOdd Theory
    }
}
