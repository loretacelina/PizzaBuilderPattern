
public class VegetarianPizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza;

    public VegetarianPizzaBuilder()
    {
        _pizza = new Pizza(); // Initialize a new pizza instance
    }

    public void SetSize(string size)
    {
        // Set the size of the pizza
        _pizza.Size = size;
    }

    public void SetCrust(string crust)
    {
        // Set the crust type of the pizza
        _pizza.Crust = crust;
    }

    public void AddToppings(string[] toppings)
    {
        // Add vegetarian-specific toppings to the pizza
        _pizza.Toppings.AddRange(new List<string> { "Olives", "Bell Peppers", "Tomatoes" });
    }

    public void AddSauces(string[] sauces)
    {
        // Add vegetarian-specific sauces to the pizza
        _pizza.Sauces.AddRange(new List<string> { "Pesto" });
    }

    public Pizza GetPizza()
    {
        // Return the built pizza
        return _pizza;
    }
}

