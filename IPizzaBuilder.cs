public interface IPizzaBuilder
{
    void SetSize(string size); // Method to set the pizza size.
    void SetCrust(string crust); // Method to set the crust type.
    void AddToppings(string[] toppings); // Method to add toppings.
    void AddSauces(string[] sauces); // Method to add sauces.
    Pizza GetPizza(); // Method to retrieve the finished product.
}