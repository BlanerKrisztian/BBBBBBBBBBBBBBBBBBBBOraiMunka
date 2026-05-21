namespace BankAccountApp
{
    public class TransactionHistory
    {
        private readonly List<(string Type, double Amount)> _transactions;

        public TransactionHistory()
        {
            _transactions = new List<(string, double)>();
        }

        // type nem lehet null/üres, amount > 0
        public void AddTransaction(string type, double amount)
        {
            throw new NotImplementedException();
        }

        public int GetTransactionCount()
        {
            throw new NotImplementedException();
        }

        // Formátum: "Deposit: 100.00" — null ha nincs tranzakció
        public string? GetLastTransaction()
        {
            throw new NotImplementedException();
        }

        public double GetTotalDeposited()
        {
            throw new NotImplementedException();
        }

        public double GetTotalWithdrawn()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
