namespace SOLID_Principles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //SRP
            Employee employee = new Employee { Name = "Ahmed Mahfouz", Salary = 8000, Department = "SD" };

            SalaryCalculator salaryCalculator = new SalaryCalculator();
            decimal yearlySalary = salaryCalculator.CalculateYearlySalary(employee);
            Console.WriteLine($"Yearly salary of {employee.Name} is {yearlySalary}");

            ReportGenerator report = new ReportGenerator();
            report.GenerateReport(employee, "Yearly Report");

            Notification notificationService = new Notification();
            notificationService.SendNotification(employee, "Your report has been generated.");

            //---------------------------------------------------------------------------------------

            //OCP
            IPaymentProcessor creditCard = new CreditCardPaymentProcessor();
            PaymentProcessor creditCardPayment = new PaymentProcessor(creditCard);
            creditCardPayment.ProcessPayment(100);

            IPaymentProcessor payPal = new PayPalPaymentProcessor();
            PaymentProcessor payPalPayment = new PaymentProcessor(payPal);
            payPalPayment.ProcessPayment(200);

            IPaymentProcessor bankTransfer = new BankTransferPaymentProcessor();
            PaymentProcessor bankTransferPayment = new PaymentProcessor(bankTransfer);
            bankTransferPayment.ProcessPayment(300);

            //---------------------------------------------------------------------------------------

            //LSP
        }
    }
}
