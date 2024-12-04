public class VegetarianPizzaBuilder : CustomPizzaBuilder
{
    public VegetarianPizzaBuilder()
    {
        // Add specific toppings for Vegetarian pizza
        AddToppings(new string[] { "Olives", "Bell Peppers", "Tomatoes" });

        // Add specific sauces for Vegetarian pizza
        AddSauces(new string[] { "Pesto" });
    }
}