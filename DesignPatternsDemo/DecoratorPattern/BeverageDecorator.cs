namespace DecoratorPattern
{
    
    public abstract class BeverageDecorator : Beverage
    {
        protected Beverage _beverage;

        protected BeverageDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription();
        }

        public override double Cost()
        {
            return _beverage.Cost();
        }
    }
}
