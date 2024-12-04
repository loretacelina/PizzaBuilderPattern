using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the builder and director.
        var builder = new CustomPizzaBuilder();
        var director = new PizzaDirector();

        // Assign the builder to the director.
        director.SetBuilder(builder);

        // Build the pizza assigned to variable pizza
        var pizza = director.BuildPizza();

        // Display the pizza.
        Console.WriteLine(pizza.ToString());
    }
}
