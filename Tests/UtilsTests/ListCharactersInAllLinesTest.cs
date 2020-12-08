using System;
using Xunit;
using AOC.Utils;

namespace AOC.UtilsTests
{
    public class ListCharactersInAllLinesTest
    {
        private const string input1 = "abc";
        private const string input2 = "a\nb\nc";
        private const string input3 = "ab\nac";
        private const string input4 = "a\na\na\na";
        private const string input5 = "b";
        private const string input6 = "abcdef\ncf";
        private const string input7 = "cbcdf\ncf";
        

        [Theory]
        [InlineData(input1, "abc")]
        [InlineData(input2, "")]
        [InlineData(input3, "a")]
        [InlineData(input4, "a")]
        [InlineData(input5, "b")]
        [InlineData(input6, "cf")]
        [InlineData(input7, "cf")]
        public void Test1(string input, string expected )
        {
            Assert.Equal(expected, StringWorker.ListCharactersInAllLines(input));
        }
    }
}