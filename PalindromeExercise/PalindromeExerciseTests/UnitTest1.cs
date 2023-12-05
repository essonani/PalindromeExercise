using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("hello",false)]
        public void Test1(string word,bool expected)
        {
            //Arrange
            var tester = new Wordsmith();
            //Act
            var actual=tester.IsApalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
