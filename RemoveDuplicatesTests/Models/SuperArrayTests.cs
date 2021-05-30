using RemoveDuplicatesDomain.Models;
using Xunit;

namespace RemoveDuplicatesTests.Models
{
    public class SuperArrayTests
    {
        [Fact]
        public void RemoveDuplicates_Should_Return_Correct_Length()
        {
            var elements = new[] { 1, 1, 2 };
            const int ExpectedResult = 2;

            var result = SuperArray.RemoveDuplicates<int>(elements);

            Assert.Equal(result, ExpectedResult);
        }
    }
}
