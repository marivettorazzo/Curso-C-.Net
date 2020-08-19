using contaBancáriaExcecoes146.Entities.Exception;
using System.Globalization;


namespace contaBancáriaExcecoes146.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WicthdrawLimit { get; set; } = 300;

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {

            Number = number;
            Holder = holder;
            Balance = balance;       
        }

        public void Deposit (double amount)
        {
           
            Balance = Balance + amount;
        }
        public void Withdraw (double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance.");
            }

            if (amount > WicthdrawLimit)
            {
                throw new DomainException("The amount exeecds withdraw limit.");
            }

            Balance = Balance - amount;
        }

        public override string ToString()
        {
            return "Number account :"
                + Number
                + ", Holder: "
                + Holder
                + ", Balance: "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
              
        }
    }
}
