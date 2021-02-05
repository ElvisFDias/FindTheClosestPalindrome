using FindTheClosestPalindrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FindTheClosestPalindromeTest
{
    public class NearestPalindromicTest
    {
        [Fact]
        public void N001_Should_Return_Closest_Palindrome()
        {
            var number = "1";
            
            var solution = new Solution();

            var result = solution.NearestPalindromic(number);

            Assert.Equal("0", result);
        }

        [Fact]
        public void N002_Should_Return_Closest_Palindrome()
        {
            var number = "1213";

            var solution = new Solution();

            var result = solution.NearestPalindromic(number);

            Assert.Equal("1221", result);
        }

        [Fact]
        public void N003_Should_Return_Closest_Palindrome()
        {
            var number = "88";

            var solution = new Solution();

            var result = solution.NearestPalindromic(number);

            Assert.Equal("77", result);
        }

        [Fact]
        public void N004_Should_Return_Closest_Palindrome()
        {
            var number = "123";

            var solution = new Solution();

            var result = solution.NearestPalindromic(number);

            Assert.Equal("121", result);
        }
    }
}
