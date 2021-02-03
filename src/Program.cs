using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace FindTheClosestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Type n: ");

                var input = Console.ReadLine();

                if (int.TryParse(input, out int n))
                {
                    var solution = new Solution();

                    var result = solution.NearestPalindromic(input);

                    Console.WriteLine($"Closest Palindrome: {result}");

                    Console.WriteLine($"{Environment.NewLine}########## End ########## {Environment.NewLine}");
                }
                else
                    break;

            }
        }
    }




}
