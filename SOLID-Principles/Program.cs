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
            AccountBase account = new Account();
            account.Deposit(100);
            Console.WriteLine($"Account Balance after deposit: {account.Balance}");
            account.Withdraw(50);
            Console.WriteLine($"Account Balance after withdrawal: {account.Balance}");

            AccountBase savingsAccount = new SavingsAccount();
            savingsAccount.Deposit(100); 
            Console.WriteLine($"Savings Account Balance after deposit: {savingsAccount.Balance}");
            savingsAccount.Withdraw(50);
            Console.WriteLine($"Savings Account Balance after withdrawal: {savingsAccount.Balance}");

            //---------------------------------------------------------------------------------------

            //ISP
            IAudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.LoadMedia("audio.mp3");
            audioPlayer.PlayAudio();

            IVideoPlayer videoPlayer = new VideoPlayer();
            videoPlayer.LoadMedia("video.mp4");
            videoPlayer.PlayVideo();
            videoPlayer.DisplaySubtitles();

            //---------------------------------------------------------------------------------------

            //DIP
            IFileReader fileReader = new FileReader();
            IFileWriter fileWriter = new FileWriter();
            FileProcessor fileProcessor = new FileProcessor(fileReader, fileWriter);
            fileProcessor.ProcessFile("input.txt", "output.txt");
        }
    }
}
