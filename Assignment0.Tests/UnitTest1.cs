using System;
using System.IO;
using Xunit;

namespace Assignment0.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(true, 2000)]
        [InlineData(true, 2004)]
        [InlineData(false, 2001)]
        [InlineData(false, 1900)]
        [InlineData(true, 1804)]
        [InlineData(true, 1600)]
        public void isLeapYear_divisibleBy4Rule(bool expected, int year)
        {
            // Assert
            Assert.Equal(expected, Program.isLeapYear(year));
        }
    }
}
