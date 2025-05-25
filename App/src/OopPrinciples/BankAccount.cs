
namespace design_patterns.src.OopPrinciples
{
    public class BankAccount
    {
        public decimal _balance { get; private set; }
        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Deposit must be greater than zero");
            _balance += amount;
        }
        public static implicit operator decimal(BankAccount account) => account._balance;

       
        public void WithDraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("WithDrawal amount must be positive");

            if (amount > _balance) throw new ArgumentOutOfRangeException("Insufficient funds ");

            this._balance -= amount;
        }

    }
}