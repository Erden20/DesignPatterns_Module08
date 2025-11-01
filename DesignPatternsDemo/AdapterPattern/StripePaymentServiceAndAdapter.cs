using System;

namespace AdapterPattern
{
    
    public class StripePaymentService
    {
        public void MakeTransaction(double totalAmount)
        {
            Console.WriteLine($"[Stripe] Making transaction for {totalAmount:0.00} USD using StripeService...");
            Console.WriteLine("[Stripe] Transaction completed.");
        }
    }

   
    public class StripePaymentAdapter : IPaymentProcessor
    {
        private readonly StripePaymentService _stripe;

        public StripePaymentAdapter(StripePaymentService stripe)
        {
            _stripe = stripe;
        }

        public void ProcessPayment(double amount)
        {
            _stripe.MakeTransaction(amount);
        }
    }
}
