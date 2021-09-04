using System;
using System.IO;
using Xunit;

namespace Assignment0.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void isLeapYear_divisibleBy4Rule()
        {
            // Assert
            Assert.Equal(true, Program.isLeapYear(4));
            Assert.Equal(true, Program.isLeapYear(0));
            Assert.Equal(true, Program.isLeapYear(40));
            Assert.Equal(true, Program.isLeapYear(204));
            Assert.Equal(true, Program.isLeapYear(32));
            Assert.Equal(false, Program.isLeapYear(3));
            Assert.Equal(false, Program.isLeapYear(7));
            Assert.Equal(false, Program.isLeapYear(17));
            Assert.Equal(false, Program.isLeapYear(1701));
        }

        [Fact]
        public void isLeapYear_divisibleBy100Rule()
        {
            // Assert
            Assert.Equal(false, Program.isLeapYear(200));
            Assert.Equal(false, Program.isLeapYear(300));
            Assert.Equal(false, Program.isLeapYear(600));
            Assert.Equal(false, Program.isLeapYear(1400));
        }

        [Fact]
        public void isLeapYear_divisibleBy400Rule()
        {
            // Assert
            Assert.Equal(true, Program.isLeapYear(400));
            Assert.Equal(true, Program.isLeapYear(800));
            Assert.Equal(true, Program.isLeapYear(8800));
        }
    }
}
