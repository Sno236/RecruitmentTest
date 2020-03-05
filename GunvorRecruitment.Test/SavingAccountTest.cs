using NUnit.Framework;

namespace GunvorRecruitment.Test
{
    [TestFixture]
    public class SavingsAccountTest
    {
        private SavingsAccount _subject;

        [Test]
        public void NeverHaveOverdraft()
        {
            Assert.Throws<AccountOverDrawnException>(() => _subject.Withdraw(-2000));
        }

        [Test]
        public void CalculateInterest()
        {
            _subject.CalculateInterest(100);
            Assert.AreEqual(102, _subject.AfterInterest);
        }

        [Test]
        public void CalculateInterestForYears()
        {
            _subject.CalculateInterestForYears(10);
            Assert.AreEqual(121.90, _subject.Compound);
        }

        

        [SetUp]
        public void SetUp()
        {
            _subject = new SavingsAccount { PersonName = "Test Person" };
        }
    }
}
