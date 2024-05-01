namespace SOLID_Principles
{
    public class Account
    {
        public decimal Balance { get; protected set; }
        public virtual decimal WithdrawalAmount { get; protected set; }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public virtual void Withdraw(decimal amount)
        {
            WithdrawalAmount = amount;
            if (Balance >= WithdrawalAmount)
            {
                Balance -= WithdrawalAmount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
        }
    }

    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }

        public override void Withdraw(decimal amount)
        {
            //Impose a withdrawal fee
            WithdrawalAmount = amount + 5.0m;
            base.Withdraw(WithdrawalAmount);
        }
    }
}


//In this case, the SavingsAccount class violates the LSP because it changes the behavior of the Withdraw method it adds a withdrawal fee to the amount being withdrawn, which is not behavior that is expected from an Account.