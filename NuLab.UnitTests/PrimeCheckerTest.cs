using NuLab.Domain.Interfaces;

namespace NuLab.UnitTests
{
    public class PrimeNumberCheckerTest
    {
        private readonly IPrimeNumberCheckerUseCase useCase;
        
        public PrimeNumberCheckerTest()
        {
            useCase = new PrimeNumberCheckerUseCase();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        public void PrimeNumberTrue(int value)
        {
            Assert.True(useCase.Execute(value));
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(1)]
        [InlineData(0)]
        [InlineData(4)]
        public void PrimeNumberFalse(int value)
        {
            Assert.False(useCase.Execute(value));
        }
    }
}