using Nu.BankAccount.Domain.Entities;
using System;
using Xunit;

namespace Nu.BankAccount.UnitTest
{
    public class TransactionTests
    {
        [Fact]
        public void Should_Create_Transactiont()
        {
            var transaction = new Transaction("merchant", 10, DateTime.Now);
            Assert.NotNull(transaction);
        }
    }
}
