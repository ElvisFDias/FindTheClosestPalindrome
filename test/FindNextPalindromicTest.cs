using FindTheClosestPalindrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FindTheClosestPalindromeTest
{
    public class FindNextPalindromicTest
    {

        [Fact]
        public void N001_Should_Return_The_Next_Palindromic()
        {
            var number = 123;
            
            var solution = new Solution();

            var nextPalindromic = solution.FindNextPalindromic(number);

            Assert.Equal(131, nextPalindromic);
        }

        [Fact]
        public void N002_Should_Return_The_Next_Palindromic()
        {
            var number = 387;

            var solution = new Solution();

            var nextPalindromic = solution.FindNextPalindromic(number);

            Assert.Equal(393, nextPalindromic);
        }


        [Fact]
        public void N003_Should_Return_The_Next_Palindromic()
        {
            var number = 3776;

            var solution = new Solution();

            var nextPalindromic = solution.FindNextPalindromic(number);

            Assert.Equal(3883, nextPalindromic);
        }

        [Fact]
        public void N004_Should_Return_The_Next_Palindromic()
        {
            var number = 10;

            var solution = new Solution();

            var nextPalindromic = solution.FindNextPalindromic(number);

            Assert.Equal(11, nextPalindromic);
        }


        [Fact]
        public void N005_Should_Return_The_Next_Palindromic()
        {
            var number = 0;

            var solution = new Solution();

            var nextPalindromic = solution.FindNextPalindromic(number);

            Assert.Equal(1, nextPalindromic);
        }

        [Fact]
        public void N006_Should_Return_The_Next_Palindromic()
        {
            var number = 9;

            var solution = new Solution();

            var nextPalindromic = solution.FindNextPalindromic(number);

            Assert.Equal(11, nextPalindromic);
        }

        [Fact]
        public void N007_Should_Return_The_Next_Palindromic()
        {
            var number = 99;

            var solution = new Solution();

            var nextPalindromic = solution.FindNextPalindromic(number);

            Assert.Equal(101, nextPalindromic);
        }

        [Fact]
        public void N008_Should_Return_The_Next_Palindromic()
        {
            var number = 37576;

            var solution = new Solution();

            var nextPalindromic = solution.FindNextPalindromic(number);

            Assert.Equal(37673, nextPalindromic);
        }
    }
}
