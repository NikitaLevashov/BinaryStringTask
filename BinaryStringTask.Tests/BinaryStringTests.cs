using NUnit.Framework;
using System;

namespace BinaryStringTask.Tests
{
    public class Tests
    {
        [TestCase("1010101010001", ExpectedResult = false)]
        [TestCase("110010", ExpectedResult = true)]
        [TestCase("010110", ExpectedResult = false)]
        [TestCase("1001110", ExpectedResult = false)]
        [TestCase("11001001", ExpectedResult = false)]
        [TestCase("10101010101100", ExpectedResult = true)]
        public static bool IsValidBinaryString_WithCorrectBinaryString_ReturnBoolResult(string source)
            => source.IsValidBinaryString();

        [Test]
        public void IsValidBinaryString_ArrayIsNull_ThrowArgumentNullException()
        {
            string value = null;
            Assert.Throws<ArgumentNullException>(() => value.IsValidBinaryString());
        }

        [Test]
        public void IsValidBinaryString_ArrayIsEmpty_ThrowArgumentException()
        {
            string value = string.Empty;
            Assert.Throws<ArgumentException>(() => value.IsValidBinaryString());
        }
    }
}