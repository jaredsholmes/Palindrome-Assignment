using System;
using System.Diagnostics.CodeAnalysis;

namespace Palindrome
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        #region Fields

        private const string Valid = "Valid";

        private const string Invalid = "Invalid";

        #endregion

        #region Methods

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to palindrome tester.\n");

            var palindrome = new Palindrome();

            while (true)
            {
                Console.Write("Enter a word or phrase: ");

                var input = Console.ReadLine();

                if(String.IsNullOrEmpty(input))
                {
                    break;
                }

                var message = palindrome.IsValid(input) ? Valid : Invalid;

                Console.WriteLine(message);
            }
        }

        #endregion
    }
}
