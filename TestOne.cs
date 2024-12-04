using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test_AddToppings()
        {
            // Arrange
            var builder = new CustomPizzaBuilder();
            var toppings = new List<string> { "Cheese", "Pepperoni" };

            // Act
            builder.AddToppings(toppings.ToArray()); // Convert List<string> to string[]
            var pizza = builder.GetPizza();

            // Assert
            CollectionAssert.AreEqual(toppings, pizza.Toppings);
        }

        [TestMethod]
        public void Test_AddSauces()
        {
            // Arrange
            var builder = new CustomPizzaBuilder();
            var sauces = new List<string> { "Tomato", "Garlic" };

            // Act
            builder.AddSauces(sauces.ToArray()); // Convert List<string> to string[]
            var pizza = builder.GetPizza();

            // Assert
            CollectionAssert.AreEqual(sauces, pizza.Sauces);
        }

        [TestMethod]
        public void Test_SetPizzaSize()
        {
            // Arrange
            var builder = new CustomPizzaBuilder();
            const string size = "Large";

            // Act
            builder.SetSize(size);
            var pizza = builder.GetPizza();

            // Assert
            Assert.AreEqual(size, pizza.Size);
        }

        [TestMethod]
        public void Test_SetPizzaCrust()
        {
            // Arrange
            var builder = new CustomPizzaBuilder();
            const string crust = "Thin";

            // Act
            builder.SetCrust(crust);
            var pizza = builder.GetPizza();

            // Assert
            Assert.AreEqual(crust, pizza.Crust);
        }

        [TestMethod]
        public void Test_FullPizzaCreation()
        {
            // Arrange
            var builder = new CustomPizzaBuilder();
            var toppings = new List<string> { "Cheese", "Pepperoni" };
            var sauces = new List<string> { "Tomato", "Garlic" };
            const string size = "Medium";
            const string crust = "Stuffed";

            // Act
            builder.SetSize(size);
            builder.SetCrust(crust);
            builder.AddToppings(toppings.ToArray());
            builder.AddSauces(sauces.ToArray());
            var pizza = builder.GetPizza();

            // Assert
            Assert.AreEqual(size, pizza.Size);
            Assert.AreEqual(crust, pizza.Crust);
            CollectionAssert.AreEqual(toppings, pizza.Toppings);
            CollectionAssert.AreEqual(sauces, pizza.Sauces);
        }
    }
}
