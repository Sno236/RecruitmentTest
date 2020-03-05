namespace GunvorRecruitment
{
    public class CurrentAccount
    {
        public decimal Balance { get; private set; }

        public int OverDraft { get; set; }

        public string PersonName { get; set; }

        public void Deposit(decimal amount)
        {
            var tempValue = Balance;
            var newValue = tempValue + amount;
            Balance = newValue;
        }

        public void Withdraw(decimal amount)
        {
            if(amount < Balance)
            {
                throw new AccountOverDrawnException() ;
            }

            var tempValue = Balance;
            var newValue = tempValue - amount;
            Balance = newValue;
        }
    }
}
