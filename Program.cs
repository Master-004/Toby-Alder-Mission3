using System;
using System.Collections.Generic;
using Mission3;

bool continueRunning = true;
List<FoodItems> inventory = new List<FoodItems>();
Console.WriteLine("Welcome to the local food bank!");
while (continueRunning)
{ 
    Console.WriteLine("\nWhich option would you like to do? (ex: 1)\n1.) Add Food Items\n2.) Delete Food Items\n3.) Print Current Inventory\n4.) Exit the Program");
    string choice = Console.ReadLine();
    if (choice == "4" || choice == null)
    {
        continueRunning = false;
    }
    else if (choice == "1")
    {
        // Create a new FoodItems object, which automatically handles input
        FoodItems item = new FoodItems(); // Constructor handles input
        inventory.Add(item);
        Console.WriteLine("Food entered successfully\n");
    }
    else if (choice == "2")
    {
        if (inventory.Count == 0)
        {
            Console.WriteLine("\nNo items in inventory to delete.\n");
        }
        else
        {
            Console.WriteLine("\nHere is our current inventory: ");
            PrintInventory(inventory);
            DeleteFoodItem(inventory);
        }
    }
    else if (choice == "3")
    {
        if (inventory.Count == 0)
        {
            Console.WriteLine("\nNo items in inventory to print out.\n");
        }
        else
        {
            Console.WriteLine("\nHere is our current inventory: ");
            PrintInventory(inventory);
        }
    }
    else
    {
        Console.WriteLine("\nThat is not an option, please choose an available option (ex: 2).");
    }
}

static void PrintInventory(List<FoodItems> inventory)
{
    for (int i = 0; i < inventory.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {inventory[i]} ");
    }
}

static void DeleteFoodItem(List<FoodItems> inventory)
{
    Console.WriteLine("Please select which food item to delete: ");
    int selection = int.Parse(Console.ReadLine());
    inventory.RemoveAt(selection - 1);
    Console.WriteLine("Food item deleted successfully.");
}
