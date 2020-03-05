namespace GunvorRecruitment
{
    public class SavingsAccount
    {
        public decimal Balance { get; private set; }

        public double AfterInterest { get; private set; }
        public double Compound
        {
            get; private set;
        }
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

        public double CalculateInterest(double amount)
        {
            double p = 0;
            if (amount != 0)
            {
                 p = 0.02 * amount;
                AfterInterest = amount + p;
            }
            return AfterInterest;
        }

        public void CalculateInterestForYears(int year)
        {

            //Compound = 100 * System.Math.Pow((1 + (2 / year)), (year));
            
            double body = 1 + (0.02 / 1);

            // nt
            double exponent = 1 * 10;

            // P(1 + r/n)^nt
            Compound =  100 * System.Math.Pow(body, exponent);


        }


    }
}
