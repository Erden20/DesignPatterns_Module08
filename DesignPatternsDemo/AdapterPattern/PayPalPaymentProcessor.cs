using System;

namespace AdapterPattern
{
    
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"[PayPal] Processing payment of {amount:0.00} USD via PayPal API...");
            Console.WriteLine("[PayPal] Payment successful.");
        }
    }
}
