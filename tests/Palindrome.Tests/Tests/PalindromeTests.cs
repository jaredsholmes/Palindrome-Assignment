using AutoFixture;
using AutoFixture.AutoMoq;
using Palindrome.Tests.Data;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Palindrome.Tests.Tests
{
    [ExcludeFromCodeCoverage]
    public class PalindromeTests
    {
        #region Tests

        [Theory]
        [ClassData(typeof(PalindromeDataSource))]
        public void IsValid_WithInput_ReturnsExpected(string input, bool expectedResult)
        {
            var fixture = new Fixture().Customize(new AutoMoqCustomization());

            var sut = fixture.Create<Palindrome>();

            Assert.Equal(expectedResult, sut.IsValid(input));
        }

        #endregion
    }
}
