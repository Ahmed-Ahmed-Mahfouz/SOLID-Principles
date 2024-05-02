using System.Diagnostics;

namespace SOLID_Principles
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(string name, decimal price, int quantity)
        {
            products.Add(new Product { Name = name, Price = price, Quantity = quantity });
        }

        public Product GetProductById(int id)
        {
            return products.Find(p => p.Id == id);
        }
    }

    public class OrderManager
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
    }

    public interface IPaymentProcessor1
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardPaymentProcessor1 : IPaymentProcessor1
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of ${amount}");
        }
    }

    public class PayPalPaymentProcessor1 : IPaymentProcessor1
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}");
        }
    }
    public interface IEmailSender
    {
        void SendEmail(Order order);
    }

    public class EmailSender : IEmailSender
    {
        public void SendEmail(Order order)
        {
            string message = $"Order confirmation for {order.CustomerName}:\n";
            message += $"Total Cost: ${order.TotalCost}\n";
            message += "Products:\n";
            foreach (Product product in order.Products)
            {
                message += $"- {product.Name} (${product.Price})\n";
            }
            Console.WriteLine(message);
        }
    }

    public class ECommerceSystem
    {
        private ProductManager productManager;
        private OrderManager orderManager;
        private IPaymentProcessor paymentProcessor;
        private IEmailSender emailSender;

        // Constructor injection for dependencies
        public ECommerceSystem(ProductManager productManager, OrderManager orderManager, IPaymentProcessor paymentProcessor, IEmailSender emailSender)
        {
            this.productManager = productManager;
            this.orderManager = orderManager;
            this.paymentProcessor = paymentProcessor;
            this.emailSender = emailSender;
        }

        public void AddProduct(string name, decimal price, int quantity)
        {
            productManager.AddProduct(name, price, quantity);
        }

        public void PlaceOrder(string customerName, List<int> productIds)
        {
            decimal totalCost = 0;
            List<Product> orderedProducts = new List<Product>();

            foreach (int productId in productIds)
            {
                Product product = productManager.GetProductById(productId);
                if (product != null && product.Quantity > 0)
                {
                    orderedProducts.Add(product);
                    totalCost += product.Price;
                    product.Quantity--;
                }
            }

            if (orderedProducts.Count > 0)
            {
                paymentProcessor.ProcessPayment((double)totalCost);

                Order order = new Order
                {
                    CustomerName = customerName,
                    Products = orderedProducts,
                    TotalCost = totalCost
                };
                orderManager.AddOrder(order);
                emailSender.SendEmail(order);
            }
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
    public class Order
    {
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalCost { get; set; }
    }
}

//The ECommerceSystem class violates SRP because it handles product management, order processing, payment processing, and sending confirmation emails. These functionalities should be separated into different classes
//The ECommerceSystem class violates OCP in the PlaceOrder method where the payment processing logic is directly implemented.
//The ECommerceSystem class directly depends on concrete implementations for processing payments and sending emails