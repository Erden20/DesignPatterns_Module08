namespace DecoratorPattern
{
    
    public class Espresso : Beverage
    {
        public override string GetDescription() => "Espresso";
        public override double Cost() => 1.50;
    }

    public class Tea : Beverage
    {
        public override string GetDescription() => "Tea";
        public override double Cost() => 1.00;
    }

    public class Latte : Beverage
    {
        public override string GetDescription() => "Latte";
        public override double Cost() => 2.50;
    }

    public class Mocha : Beverage
    {
        public override string GetDescription() => "Mocha";
        public override double Cost() => 3.00;
    }
}
