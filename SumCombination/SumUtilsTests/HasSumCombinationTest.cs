using SumCombination;

namespace SumUtilsTests
{
    public class HasSumCombinationTest
    {
        [Fact]
        public void HasSumCombinationTrue()
        {
            // Arrange
            List<int> numbers = new List<int> { 5, 1, 2, 7, 8 };
            int targetSum = 13;

            // Act
            bool result = SumUtils.HasSumCombination(numbers, targetSum);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void HasSumCombinationFalse()
        {
            // Arrange
            List<int> numbers = new List<int> { 5, 1, 2, 7, 8 };
            int targetSum = 20;

            // Act
            bool result = SumUtils.HasSumCombination(numbers, targetSum);

            // Assert
            Assert.False(result);
        }
    }
}