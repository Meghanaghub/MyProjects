
namespace BankTests
{
    public class Tests
    {
        private BankAccount account;
        
        private Transactions transaction;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount("Meghana");
            transaction = new Transactions();
        }

        [Test]
        public void Intialized_Balance_With_0()
        {
            Assert.That(0, Is.EqualTo(account.Balance));
        }

        [Test]
        public void Adding_Amount_Updates_Bal()
        {
            account.Deposit(1000);

            Assert.That(1000,Is.EqualTo(account.Balance));
        }

        [Test]
        public void Withdraw_Amount_Updates_Bal()
        {
            account.Deposit(1000);
            account.Withdraw(200);

            Assert.That(800, Is.EqualTo(account.Balance));
        }

        [Test]
        public void Deposit_throw()
        {
            string result = account.Deposit(-1);
            Assert.That("Deposit Failed! Please check the amount entered", Is.EqualTo(result) );
        }

        [Test]
        public void Withdraw_throw()
        {
            string result = account.Withdraw(2000);
            Assert.That("Withdraw Failed! Please check the amount entered and the account Balance", Is.EqualTo(result));
        }
    }
}