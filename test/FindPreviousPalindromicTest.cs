using FindTheClosestPalindrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FindTheClosestPalindromeTest
{
    public class FindPreviousPalindromicTest
    {

        [Fact]
        public void N001_Should_Return_The_Previous_Palindromic()
        {
            var number = 123;
            
            var solution = new Solution();

            var previousPalindromic = solution.FindPreviousPalindromic(number);

            Assert.Equal(121, previousPalindromic);
        }

        [Fact]
        public void N002_Should_Return_The_Previous_Palindromic()
        {
            var number = 387;

            var solution = new Solution();

            var previousPalindromic = solution.FindPreviousPalindromic(number);

            Assert.Equal(383, previousPalindromic);
        }


        [Fact]
        public void N003_Should_Return_The_Previous_Palindromic()
        {
            var number = 3776;

            var solution = new Solution();

            var previousPalindromic = solution.FindPreviousPalindromic(number);

            Assert.Equal(3773, previousPalindromic);
        }

        [Fact]
        public void N004_Should_Return_The_Previous_Palindromic()
        {
            var number = 10;

            var solution = new Solution();

            var previousPalindromic = solution.FindPreviousPalindromic(number);

            Assert.Equal(9, previousPalindromic);
        }


        [Fact]
        public void N005_Should_Return_The_Previous_Palindromic()
        {
            var number = 0;

            var solution = new Solution();

            var previousPalindromic = solution.FindPreviousPalindromic(number);

            Assert.Equal(0, previousPalindromic);
        }

        [Fact]
        public void N006_Should_Return_The_Previous_Palindromic()
        {
            var number = 9;

            var solution = new Solution();

            var previousPalindromic = solution.FindPreviousPalindromic(number);

            Assert.Equal(8, previousPalindromic);
        }

        [Fact]
        public void N007_Should_Return_The_Previous_Palindromic()
        {
            var number = 99;

            var solution = new Solution();

            var previousPalindromic = solution.FindPreviousPalindromic(number);

            Assert.Equal(88, previousPalindromic);
        }

        [Fact]
        public void N008_Should_Return_The_Previous_Palindromic()
        {
            var number = 37576;

            var solution = new Solution();

            var previousPalindromic = solution.FindPreviousPalindromic(number);

            Assert.Equal(37573, previousPalindromic);
        }


        [Fact]
        public void N009_Should_Return_The_Previous_Palindromic()
        {
            var number = 1;

            var solution = new Solution();

            var previousPalindromic = solution.FindPreviousPalindromic(number);

            Assert.Equal(0, previousPalindromic);
        }

        [Fact]
        public void N010_Should_Return_The_Previous_Palindromic()
        {
            var number = 11;

            var solution = new Solution();

            var previousPalindromic = solution.FindPreviousPalindromic(number);

            Assert.Equal(9, previousPalindromic);
        }
    }
}
