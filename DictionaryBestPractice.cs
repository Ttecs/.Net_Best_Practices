using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary to store employee information (employee ID as the key and employee name as the value).
        Dictionary<int, string> employeeDictionary = new Dictionary<int, string>();

        // Best practice #3: Check for key existence before accessing.
        if (!employeeDictionary.ContainsKey(101))
        {
            // Best practice #4: Use TryGetValue to avoid exceptions.
            if (employeeDictionary.TryGetValue(101, out var value))
            {
                Console.WriteLine($"Employee Name: {value}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        // Add employees to the dictionary.
        employeeDictionary.Add(101, "Alice");
        employeeDictionary.Add(102, "Bob");
        employeeDictionary.Add(103, "Charlie");

        // Best practice #6: Avoid frequent resizing by setting the initial capacity if known.
        // Best practice #8: Use thread-safe data structures if needed (ConcurrentDictionary).
        // Best practice #11: Use clear and meaningful variable names.
        // Best practice #12: Add comments or documentation.
        
        // Retrieve employee names.
        if (employeeDictionary.ContainsKey(102))
        {
            string employeeName = employeeDictionary[102]; // Direct indexing.
            Console.WriteLine($"Employee 102: {employeeName}");
        }

        // Best practice #10: Proper error handling for key not found.
        if (employeeDictionary.ContainsKey(104))
        {
            Console.WriteLine($"Employee 104: {employeeDictionary[104]}");
        }
        else
        {
            Console.WriteLine("Employee 104 not found.");
        }

        // Best practice #14: Avoid nested dictionaries.

        // Clean-up unused entries.
        employeeDictionary.Remove(101);

        // Display all employees.
        Console.WriteLine("All Employees:");
        foreach (var kvp in employeeDictionary)
        {
            Console.WriteLine($"Employee ID: {kvp.Key}, Name: {kvp.Value}");
        }
    }
}
