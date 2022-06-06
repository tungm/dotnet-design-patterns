using SimpleFactory;

Coffee blackCoffee = CoffeeFactory.MakeCoffee(CoffeeType.BlackCoffee);
Console.WriteLine(blackCoffee.GetDescription());

Coffee milkCoffee = CoffeeFactory.MakeCoffee(CoffeeType.MilkCoffee);
Console.WriteLine(milkCoffee.GetDescription());

Coffee eggCoffee = CoffeeFactory.MakeCoffee(CoffeeType.EggCoffee);
Console.WriteLine(eggCoffee.GetDescription());
