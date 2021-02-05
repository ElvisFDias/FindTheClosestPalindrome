using System;

namespace FindTheClosestPalindrome
{
    public class Solution
    {   
        public string NearestPalindromic(string n)
        {
            
            var number = long.Parse(n);

            var nextPalindromic = FindNextPalindromic(number);

            var previousPalindromic = FindPreviousPalindromic(number);

            var nextDiff = nextPalindromic - number;

            var previousDiff = number - previousPalindromic;

            if (nextDiff < previousDiff)
                return nextPalindromic.ToString();

            return previousPalindromic.ToString();

        }

        public long FindNextPalindromic(long number)
        {
            number++;

            while (true)
            {
                var operationResult = NumericOperation.IsPalindromic(number);

                if (operationResult.IsPalindromic)
                    return number;

                long diff;

                if (operationResult.NumberDiffA > operationResult.NumberDiffB)
                    diff = (operationResult.NumberDiffB + 10) - operationResult.NumberDiffA; 
                else
                    diff = operationResult.NumberDiffB - operationResult.NumberDiffA;

                number += (diff * Pow(10, operationResult.DiferentIndex));
            }

        }

        public long FindPreviousPalindromic(long number)
        {
            number--;

            if (number <= 0)
                return 0;

            while (true)
            {
                var operationResult = NumericOperation.IsPalindromic(number);

                if (operationResult.IsPalindromic)
                    return number;

                long diff;

                if (operationResult.NumberDiffA > operationResult.NumberDiffB)
                    diff = operationResult.NumberDiffA - operationResult.NumberDiffB;
                else if (operationResult.DiferentIndex == 0)
                    diff = 1;
                else
                    diff = (operationResult.NumberDiffA + 10) - operationResult.NumberDiffB;

                number = number - (diff * Pow(10, operationResult.DiferentIndex));
            }
        }

        private long Pow(long x, long y)
        {
            return (long)Math.Pow(x, y);
        }

        public class NumericOperationResult
        {
            public bool IsPalindromic { get; set; }
            public int DiferentIndex { get; set; }
            public long NumberDiffA { get; set; }
            public long NumberDiffB  { get; set; }
        }

        public static class NumericOperation
        {
            private static long CharToLong(Char c)
            {
                return long.Parse(c.ToString());
            }

            public static NumericOperationResult IsPalindromic2(long num)
            {
                long reverse = 0;
                var numberAux = num;
                while (numberAux > 0)
                {
                    reverse = reverse * 10 + numberAux % 10;

                    numberAux /= 10;
                }

                if (num == reverse)
                    return new NumericOperationResult() { IsPalindromic = true, DiferentIndex = -1 };

                var pow = 0;
                while (num > 0)
                {
                    var reverseRest = reverse % 10;
                    var numRest = num % 10;

                    if (reverseRest != numRest)
                    {
                        return new NumericOperationResult() { IsPalindromic = false, DiferentIndex = pow, NumberDiffA = numRest , NumberDiffB = reverseRest };
                    }
                        

                    reverse = reverse / 10;
                    num = num / 10;
                    pow++;
                }

                return new NumericOperationResult() { IsPalindromic = false, DiferentIndex = -1 };
            }

            public static NumericOperationResult IsPalindromic(long num)
            {
                var numa = num.ToString();
                var lastIndex = numa.Length - 1;
                var pow = 0;

                for (int i = 0; i < numa.Length / 2; i++)
                {

                    if(numa[i] != numa[lastIndex - i])
                    {
                        return new NumericOperationResult() { IsPalindromic = false, DiferentIndex = pow, NumberDiffA = CharToLong(numa[lastIndex - i]), NumberDiffB = CharToLong(numa[i])  };
                    }

                    pow++;
                }
              
                return new NumericOperationResult() { IsPalindromic = true, DiferentIndex = -1 };
              
            }
        }

    }




}
