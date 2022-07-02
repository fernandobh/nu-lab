using Nu.BankAccount.Application.Usecases;
using Nu.BankAccount.Domain.Entities;
using System;
using Xunit;

namespace Nu.BankAccount.UnitTest
{
    public class CreateAccountTests
    {
        private readonly CreateAccountOutput output;

        public CreateAccountTests()
        {
            output = new CreateAccountOutput();
        }

        [Fact]
        public void Should_Create_Account()
        {
            var inpupt = new CreateAccountInput() { Active = true, AvailableLimite = 100 };

            var useCase = new CreateAccountUseCase();
            useCase.Execute(output, inpupt);

            Assert.NotNull(output.CreateAccountResult);
        }
    }
}
