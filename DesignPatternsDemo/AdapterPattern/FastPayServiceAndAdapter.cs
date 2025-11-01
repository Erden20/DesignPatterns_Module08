using System;

namespace AdapterPattern
{
    
    public class FastPayService
    {
        public bool Send(double dollars, string currency = "USD")
        {
            Console.WriteLine($"[FastPay] Sending {dollars:0.00} {currency} via FastPay...");
            Console.WriteLine("[FastPay] Success.");
            return true;
        }
    }

    
    public class FastPayAdapter : IPaymentProcessor
    {
        private readonly FastPayService _fastPay;

        public FastPayAdapter(FastPayService fastPay)
        {
            _fastPay = fastPay;
        }

        public void ProcessPayment(double amount)
        {
            bool success = _fastPay.Send(amount, "USD");
            if (!success)
            {
                Console.WriteLine("[FastPayAdapter] Payment failed.");
            }
        }
    }
}
