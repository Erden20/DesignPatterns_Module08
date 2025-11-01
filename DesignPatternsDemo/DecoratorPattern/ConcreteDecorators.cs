namespace DecoratorPattern
{
    
    public class Milk : BeverageDecorator
    {
        public Milk(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Milk";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.30;
        }
    }

    public class Sugar : BeverageDecorator
    {
        public Sugar(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Sugar";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.10;
        }
    }

    public class WhippedCream : BeverageDecorator
    {
        public WhippedCream(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Whipped Cream";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.70;
        }
    }

    public class VanillaSyrup : BeverageDecorator
    {
        public VanillaSyrup(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Vanilla Syrup";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.50;
        }
    }
}
