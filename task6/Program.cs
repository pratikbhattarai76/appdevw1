using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of fruits
        List<string> fruits = new List<string>
        {
            "Mango",
            "Apple",
            "Banana"
        };

        // Add a new fruit
        fruits.Add("Orange");

        // Remove a fruit
        fruits.Remove("Apple");

        // Print all fruits
        Console.WriteLine("Fruits:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Create a dictionary
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Mango" },
            { 2, "Apple" },
            { 3, "Banana" }
        };

        // Add a new entry
        fruitDictionary.Add(4, "Orange");

        // Print all key-value pairs
        Console.WriteLine("\nFruit Dictionary:");

        foreach (KeyValuePair<int, string> item in fruitDictionary)
        {
            Console.WriteLine($"ID: {item.Key}, Fruit: {item.Value}");
        }
    }
}