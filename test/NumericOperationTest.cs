using FindTheClosestPalindrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static FindTheClosestPalindrome.Solution;

namespace FindTheClosestPalindromeTest
{
    public class NumericOperationTest
    {

        [Fact]
        public void N001_Should_Return_True_If_Number_Is_Palindromic()
        {
            var number = 1111; 
           
            var result = NumericOperation.IsPalindromic(number);

            Assert.True(result.IsPalindromic);
        }

        [Fact]
        public void N002_Should_Return_True_If_Number_Is_Palindromic()
        {
            var number = 121;

            var result = NumericOperation.IsPalindromic(number);

            Assert.True(result.IsPalindromic);
        }

        [Fact]
        public void N003_Should_Return_True_If_Number_Is_Palindromic()
        {
            var number = 1;

            var result = NumericOperation.IsPalindromic(number);

            Assert.True(result.IsPalindromic);
        }


        [Fact]
        public void N004_Should_Return_False_If_Number_Is_Palindromic()
        {
            var number = 123;

            var result = NumericOperation.IsPalindromic(number);

            Assert.False(result.IsPalindromic);
            Assert.Equal(0, result.DiferentIndex);
        }



        [Fact]
        public void N005_Should_Return_False_If_Number_Is_Palindromic()
        {
            var number = 1231;

            var result = NumericOperation.IsPalindromic(number);

            Assert.False(result.IsPalindromic);
            Assert.Equal(1, result.DiferentIndex);
        }


    }
}
