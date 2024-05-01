namespace SOLID_Principles
{
    public abstract class AccountBase
    {
        public decimal Balance { get; protected set; }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public abstract void Withdraw(decimal amount);
    }

    public class Account : AccountBase
    {
        public override void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
        }
    }

    public class SavingsAccount : AccountBase
    {
        public decimal InterestRate { get; set; }

        public override void Withdraw(decimal amount)
        {
            //Impose a withdrawal fee
            amount += 5.0m;

            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
        }
    }
}




//In this case, the SavingsAccount class violates the LSP because it changes the behavior of the Withdraw method it adds a withdrawal fee to the amount being withdrawn, which is not behavior that is expected from an Account.