using System.Linq;

public class CustomPizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza = new Pizza(); // The product being built.

    public void SetSize(string size)
    {
        _pizza.Size = size;
    }

    public void SetCrust(string crust)
    {
        _pizza.Crust = crust;
    }

    public void AddToppings(string[] toppings)
    {
        _pizza.Toppings.AddRange(toppings);
    }

    public void AddSauces(string[] sauces)
    {
        _pizza.Sauces.AddRange(sauces);
    }

    public Pizza GetPizza()
    {
        return _pizza; // Return the finished pizza.
    }
}
