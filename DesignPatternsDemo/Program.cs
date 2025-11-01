using System;
using DecoratorPattern;
using AdapterPattern;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Decorator Pattern: Cafe Beverage Demo ===");
        
        // Создаём базовый напиток и добавляем к нему добавки
        Beverage beverage = new Espresso();
        beverage = new Milk(beverage);
        beverage = new Sugar(beverage);
        beverage = new WhippedCream(beverage);

        Console.WriteLine($"Order: {beverage.GetDescription()}");
        Console.WriteLine($"Total cost: {beverage.Cost():0.00} USD");
        Console.WriteLine();

        // Другой пример
        Beverage latte = new Latte();
        latte = new VanillaSyrup(latte);
        latte = new Milk(latte);

        Console.WriteLine($"Order: {latte.GetDescription()}");
        Console.WriteLine($"Total cost: {latte.Cost():0.00} USD");
        Console.WriteLine();

        Console.WriteLine("=== Adapter Pattern: Payment Processors Demo ===");

        IPaymentProcessor paypal = new PayPalPaymentProcessor();
        IPaymentProcessor stripe = new StripePaymentAdapter(new StripePaymentService());
        IPaymentProcessor fastPay = new FastPayAdapter(new FastPayService());

        Console.WriteLine("-- Paying with PayPal --");
        paypal.ProcessPayment(12.50);
        Console.WriteLine();

        Console.WriteLine("-- Paying with Stripe (adapter) --");
        stripe.ProcessPayment(45.00);
        Console.WriteLine();

        Console.WriteLine("-- Paying with FastPay (another adapter) --");
        fastPay.ProcessPayment(99.99);
        Console.WriteLine();

        Console.WriteLine("Demo finished. Press any key to exit.");
    }
}
