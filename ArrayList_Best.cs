using System;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            // Adding elements to ArrayList
            list.Add(42);
            list.Add("Hello");
            list.Add(3.14);
            list.Add(new Person("Alice", 30));

            // Accessing elements
            foreach (var item in list)
            {
                if (item is int intValue)
                {
                    Console.WriteLine($"Integer Value: {intValue}");
                }
                else if (item is string stringValue)
                {
                    Console.WriteLine($"String Value: {stringValue}");
                }
                else if (item is double doubleValue)
                {
                    Console.WriteLine($"Double Value: {doubleValue}");
                }
                else if (item is Person person)
                {
                    Console.WriteLine($"Person: {person.Name}, Age: {person.Age}");
                }
            }

            // Removing an element
            list.Remove(42);

            // Best practice: Use foreach or for loop for iteration
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
