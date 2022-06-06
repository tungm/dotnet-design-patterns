namespace SimpleFactory;

class CoffeeFactory
{
    public static Coffee MakeCoffee(CoffeeType coffeeType)
    {
        switch (coffeeType)
        {
            case CoffeeType.BlackCoffee:
                return new BlackCoffee();
            case CoffeeType.MilkCoffee:
                return new MilkCoffee();
            case CoffeeType.EggCoffee:
                return new EggCoffee();
            default:
                throw new ArgumentException("Unknown type of coffee!");
        }
    }
}