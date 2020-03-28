using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Palindrome.Tests.Data
{
    [ExcludeFromCodeCoverage]
    public class PalindromeDataSource : IEnumerable<object[]>
    {
        #region Methods

        public IEnumerator<object[]> GetEnumerator()
        {
            // Valid
            yield return new object[] { "racecar", true };
            yield return new object[] { "Mom", true };
            yield return new object[] { "Was it a cat I saw?", true };
            yield return new object[] { "Red rum, sir, is murder", true };
            yield return new object[] { "Madam, in Eden, I’m Adam.", true };
            yield return new object[] { "Yo, banana boy!", true };
            yield return new object[] { "Oozy rat in a sanitary zoo.", true };
            yield return new object[] { "Taco cat", true };
            yield return new object[] { "Too bad--I hid a boot.", true };
            yield return new object[] { "Yo, bottoms up! (U.S. motto, boy.)", true };
            yield return new object[] { "", true };
            yield return new object[] { "          ", true };

            // Invalid
            yield return new object[] { "Yikes", false };
            yield return new object[] { "Hello-World", false };
            yield return new object[] { "  Testing  ", false };
            yield return new object[] { "987654321  ", false };
            yield return new object[] { null, false };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion
    }
}
