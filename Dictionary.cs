using System;
using System.Collections.Generic;
using System.Linq;

namespace Module7DictionaryProject
{
    class Program
    {
        // Dictionary where each key maps to a list of values
        static Dictionary<string, List<string>> myDictionary = new Dictionary<string, List<string>>();

        static void Main(string[] args)
        {
            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("\n===== DICTIONARY MENU =====");
                Console.WriteLine("1. Populate Dictionary");
                Console.WriteLine("2. Display Dictionary Contents");
                Console.WriteLine("3. Remove a Key");
                Console.WriteLine("4. Add New Key and Value");
                Console.WriteLine("5. Add Value to Existing Key");
                Console.WriteLine("6. Sort Keys");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        PopulateDictionary();
                        break;

                    case 2:
                        DisplayContents();
                        break;

                    case 3:
                        RemoveKey();
                        break;

                    case 4:
                        AddKeyAndValue();
                        break;

                    case 5:
                        AddValueToExistingKey();
                        break;

                    case 6:
                        SortDictionaryKeys();
                        break;

                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        // (a) Populate the dictionary
        static void PopulateDictionary()
        {
            myDictionary.Clear();

            myDictionary.Add("Fruits", new List<string> { "Apple", "Banana", "Orange" });
            myDictionary.Add("Animals", new List<string> { "Dog", "Cat", "Horse" });
            myDictionary.Add("Colors", new List<string> { "Red", "Blue", "Green" });

            Console.WriteLine("Dictionary successfully populated.");
        }

        // (b) Display dictionary contents using three enumeration methods
        static void DisplayContents()
        {
            if (myDictionary.Count == 0)
            {
                Console.WriteLine("Dictionary is empty. Populate it first.");
                return;
            }

            Console.WriteLine("\n=== METHOD 1: foreach over KeyValuePair ===");
            foreach (var pair in myDictionary)
            {
                Console.WriteLine($"{pair.Key}: {string.Join(", ", pair.Value)}");
            }

            Console.WriteLine("\n=== METHOD 2: Loop through Keys list ===");
            foreach (var key in myDictionary.Keys)
            {
                Console.WriteLine($"{key}: {string.Join(", ", myDictionary[key])}");
            }

            Console.WriteLine("\n=== METHOD 3: Loop through Values list ===");
            foreach (var valueList in myDictionary.Values)
            {
                Console.WriteLine(string.Join(", ", valueList));
            }
        }

        // (c) Remove a key
        static void RemoveKey()
        {
            Console.Write("Enter the key to remove: ");
            string key = Console.ReadLine();

            if (myDictionary.Remove(key))
                Console.WriteLine($"Key '{key}' was removed.");
            else
                Console.WriteLine($"Key '{key}' not found.");
        }

        // (d) Add a new key/value pair
        static void AddKeyAndValue()
        {
            Console.Write("Enter a new key: ");
            string key = Console.ReadLine();

            if (myDictionary.ContainsKey(key))
            {
                Console.WriteLine("That key already exists.");
                return;
            }

            Console.Write("Enter a value for this key: ");
            string value = Console.ReadLine();

            myDictionary[key] = new List<string> { value };

            Console.WriteLine($"Added key '{key}' with value '{value}'.");
        }

        // (e) Add a value to an existing key
        static void AddValueToExistingKey()
        {
            Console.Write("Enter the key to add a value to: ");
            string key = Console.ReadLine();

            if (!myDictionary.ContainsKey(key))
            {
                Console.WriteLine("Key not found.");
                return;
            }

            Console.Write("Enter the new value to add: ");
            string value = Console.ReadLine();

            myDictionary[key].Add(value);

            Console.WriteLine($"Added '{value}' to key '{key}'.");
        }

        // (f) Sort the dictionary by keys
        static void SortDictionaryKeys()
        {
            var sorted = myDictionary.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            myDictionary = sorted;

            Console.WriteLine("Dictionary keys sorted alphabetically.");
        }
    }
}
