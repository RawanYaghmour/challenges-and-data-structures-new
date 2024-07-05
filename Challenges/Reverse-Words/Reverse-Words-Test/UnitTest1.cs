using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace Reverse_Words_Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestCase1()
        {
            // Arrange
            string input = "csharp is programming language";
            string expected = "language programming is csharp";

            // Act
            string result = Program.ReverseWords(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCase2()
        {
            // Arrange
            string input = "Reverse the words in this sentence";
            string expected = "sentence this in words the Reverse";

            // Act
            string result = Program.ReverseWords(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCase3()
        {
            // Arrange
            string input = "challenges and data structures";
            string expected = "structures data and challenges";

            // Act
            string result = Program.ReverseWords(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}