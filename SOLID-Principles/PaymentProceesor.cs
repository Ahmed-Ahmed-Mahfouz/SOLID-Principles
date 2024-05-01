namespace SOLID_Principles
{
    // The IPaymentProcessor interface defines a method for processing payments.
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }

    // The CreditCardPaymentProcessor class is responsible for processing credit card payments.
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            //Process credit card payment
        }
    }

    // The PayPalPaymentProcessor class is responsible for processing PayPal payments.
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            //Process PayPal payment
        }
    }

    // The BankTransferPaymentProcessor class is responsible for processing bank transfer payments.
    public class BankTransferPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            //Process bank transfer payment
        }
    }

    // The ProcessPayment method is responsible for processing payments based on the payment type.
    public class PaymentProcessor
    {
        IPaymentProcessor paymentProcessor;

        public PaymentProcessor(IPaymentProcessor paymentProcessor)
        {
            this.paymentProcessor = paymentProcessor;
        }
        public void ProcessPayment(double amount)
        {
            paymentProcessor.ProcessPayment(amount);
        }
    }
}

//The varying part of the PaymentProcessor class is the implementation of how each payment type is processed. 
//The stable part of the PaymentProcessor class is the ProcessPayment method itself.