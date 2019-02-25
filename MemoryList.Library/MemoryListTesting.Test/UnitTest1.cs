using System;
using System.Linq;
using Xunit;
using MemoryList.cs;


namespace MemoryListTesting.Test
{
    public class UnitTest1
    {
        [Fact]
        public void AddShouldNotThrowException()
        {
            var Memory = new MemoryList();

            Memory.Add("blah");
        }

        [Fact]
        public void ContainsShouldBeFalse()
        {
            var Memory = new MemoryList();

            var result = Memory.Contains("asdf");

            Assert.False(result);
        }

        [Fact]
        public void RemoveShouldNotThrowException()
        {
            var Memory = new MemoryList();

            Memory.Add("blah");

            Memory.Remove();

            var result = Memory.Contains("blah");

            Assert.False(result);
        }
    }
}
