using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Jakub's Pizza Shop!");

        // Get user input for pizza details
        Console.Write("Enter your name: ");
        string customerName = Console.ReadLine();

        Console.Write("Enter pizza size (small, medium, large): ");
        string pizzaSize = Console.ReadLine();

        Console.Write("Enter toppings (comma-separated): ");
        string toppings = Console.ReadLine();

        // Calculate total price based on pizza size and toppings
        double totalPrice = CalculatePrice(pizzaSize, toppings);

        // Display order summary
        Console.WriteLine($"\nOrder Summary for {customerName}:");
        Console.WriteLine($"Pizza Size: {pizzaSize}");
        Console.WriteLine($"Toppings: {toppings}");
        Console.WriteLine($"Total Price: ${totalPrice}");

        // Thank the customer
        Console.WriteLine("\nThank you for ordering from Jakub's Pizza Shop!");
    }

    static double CalculatePrice(string size, string toppings)
    {
        // You can customize the pricing logic based on your preferences
        double basePrice = 10.0;

        // Adjust price based on size
        switch (size.ToLower())
        {
            case "small":
                basePrice += 5.0;
                break;
            case "medium":
                basePrice += 8.0;
                break;
            case "large":
                basePrice += 10.0;
                break;
            default:
                Console.WriteLine("Invalid pizza size. Defaulting to medium size.");
                break;
        }

        // Adjust price based on the number of toppings
        int numberOfToppings = toppings.Split(',').Length;
        basePrice += numberOfToppings * 1.5;

        return basePrice;
    }
}
