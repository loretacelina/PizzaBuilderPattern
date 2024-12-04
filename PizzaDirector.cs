public class PizzaDirector
{
    private IPizzaBuilder _builder; // The builder used to construct the pizza.

    public void SetBuilder(IPizzaBuilder builder)
    {
        _builder = builder; // Assign the builder.
    }

    public Pizza BuildPizza()
    {
        // Orchestrates the building of a complete pizza.
        _builder.SetSize("Large");
        _builder.SetCrust("Thin");
        _builder.AddToppings(new[] { "Cheese", "Pepperoni", "Olives" });
        _builder.AddSauces(new[] { "Tomato", "Garlic" });
        return _builder.GetPizza();
    }
}
