using System.Collections.Generic;

public class Pizza
{
    public string Size { get; set; } // Size of the pizza.
    public string Crust { get; set; } // Crust type.
    public List<string> Toppings { get; set; } = new List<string>(); // List of toppings.
    public List<string> Sauces { get; set; } = new List<string>(); // List of sauces.

    // Override the ToString method for a readable summary of the pizza.
    public override string ToString()
    {
        return $"Pizza Size: {Size}, Crust: {Crust}, Toppings: {string.Join(", ", Toppings)}, Sauces: {string.Join(", ", Sauces)}";
    }
}
