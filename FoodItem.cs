using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    internal class FoodItems
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string ExpirationDate { get; set; }

        // Constructor to handle input
        public FoodItems()
        {
            Console.WriteLine("\nEnter the name of the food item: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter the category (e.g., Canned Goods, Dairy, etc.): ");
            Category = Console.ReadLine();

            // Error handling with negative numbers
            bool isValid = false;

            while (!isValid)
            {
                Console.Write("Enter the quantity: ");
                string input = Console.ReadLine();

                try
                {
                    Quantity = int.Parse(input); // Attempt to convert input to an integer
                    if (Quantity < 0)
                    {
                        throw new ArgumentException("Quantity cannot be negative.");
                    }
                    isValid = true; // Exit the loop if no exception is thrown
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message); // Display the error message
                }
            }

            Console.WriteLine("Enter the expiration date (ex: yyyy-MM-dd): ");
            ExpirationDate = Console.ReadLine();
        }

        // Override ToString to display the FoodItem details neatly
        public override string ToString()
        {
            return $"{Name} ({Category}) - Quantity: {Quantity}, Expiration Date: {ExpirationDate}";
        }
    }
}
