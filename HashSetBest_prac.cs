using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a HashSet to store unique names
        HashSet<string> uniqueNames = new HashSet<string>();

        // Add names to the HashSet
        uniqueNames.Add("Alice");
        uniqueNames.Add("Bob");
        uniqueNames.Add("Charlie");

        // Attempt to add a duplicate name (won't raise an error, but it won't be stored)
        uniqueNames.Add("Alice");

        // Check if a name exists in the HashSet
        string searchName = "Bob";
        if (uniqueNames.Contains(searchName))
        {
            Console.WriteLine($"{searchName} is in the HashSet.");
        }
        else
        {
            Console.WriteLine($"{searchName} is not in the HashSet.");
        }

        // Iterate through the unique names in the HashSet
        Console.WriteLine("Unique Names in the HashSet:");
        foreach (var name in uniqueNames)
        {
            Console.WriteLine(name);
        }

        // Remove a name from the HashSet
        string removedName = "Charlie";
        if (uniqueNames.Remove(removedName))
        {
            Console.WriteLine($"{removedName} removed from the HashSet.");
        }
        else
        {
            Console.WriteLine($"{removedName} not found in the HashSet.");
        }

        // Display the updated list of unique names
        Console.WriteLine("Updated Unique Names in the HashSet:");
        foreach (var name in uniqueNames)
        {
            Console.WriteLine(name);
        }
    }
}
