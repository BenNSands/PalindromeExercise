using PalindromeExercise;
using System;
using Xunit;
using System.Linq;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("dad", true)]
        [InlineData("god", false)]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("RaceCar", true)]
        public void IsAPalindrome(string word, bool expected)
        {
            //Arrange
            var test = new WordSmith();
            //Act
            var actual = test.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
