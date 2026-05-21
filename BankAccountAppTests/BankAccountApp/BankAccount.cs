namespace BankAccountApp
{
    public class BankAccount
    {
        private double _balance;
        private readonly string _owner;
        private readonly TransactionHistory _history;

        // owner nem lehet null/üres, initialBalance nem lehet negatív
        public BankAccount(string owner, double initialBalance = 0)
        {
            throw new NotImplementedException();
        }

        public string GetOwner()
        {
            throw new NotImplementedException();
        }

        public double GetBalance()
        {
            throw new NotImplementedException();
        }

        // Visszatér false ha amount <= 0
        public bool Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        // Visszatér false ha amount <= 0 vagy nincs elég fedezet
        public bool Withdraw(double amount)
        {
            throw new NotImplementedException();
        }

        // Visszatér false ha target null, amount érvénytelen, vagy nincs fedezet
        public bool Transfer(BankAccount target, double amount)
        {
            throw new NotImplementedException();
        }

        public TransactionHistory GetHistory()
        {
            throw new NotImplementedException();
        }
    }
}
