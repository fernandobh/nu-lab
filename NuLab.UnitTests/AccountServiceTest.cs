using NSubstitute;
using NuLab.Domain.Entities;
using NuLab.Domain.Interfaces;

namespace NuLab.UnitTests
{
    public class AccountServiceTest
    {
        private readonly IAccountRepository accountRepository;
        private IAccountServices? accountServices;

        public AccountServiceTest()
        {
            accountRepository = Substitute.For<IAccountRepository>();
        }


        [Fact]
        public void ShouldBeCreateAccount()
        {
            accountServices = new AccountServices(accountRepository);

            var newAccount = new Account(true, 100);

            var response = accountServices.Create(newAccount.AvailableLimite);

            Assert.NotNull(response);
            Assert.True(
                response.Active && 
                response.AvailableLimite == newAccount.AvailableLimite && 
                string.IsNullOrEmpty(response.Violation));
        }


        [Fact]
        public void ShouldBeNotCreateAccount()
        {
            var newAccount = new Account(true, 100);
            accountRepository.Get().Returns(newAccount);            
            accountServices = new AccountServices(accountRepository);            

            Assert.Throws<Exception>(() => accountServices.Create(newAccount.AvailableLimite+1));
        }


        [Fact]
        public void ShouldBeAddTransaction()
        {
            var account = new Account(true, 100);
            accountRepository.Get().Returns(account);

            var transaction = new Transaction()
            {
                Amount = 10,
                LocalDateTime = DateTime.UtcNow,
                Merchant = "tests"
            };

            var accountServices = new AccountServices(accountRepository);
            var response = accountServices.Transaction(transaction);

            Assert.True(
                response.AvailableLimite == 90 &&
                response.Active &&
                string.IsNullOrEmpty(response.Violation));
        }


        [Fact]
        public void ShouldBeNotAddTransaction()
        {

        }
    }
}
