namespace HashMap_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a dictionary to store <key, value> pairs
            Dictionary<string, int> ages = new Dictionary<string, int>();

            // Adding elements to the dictionary
            AddOrUpdateAge(ages, "Kieran", 29);
            AddOrUpdateAge(ages, "James", 29);
            ages["Jason"] = 32;
            ages.Add("Cheryl", 26);

            // Accessing elements in the dictionary
            DisplayAge(ages, "Kieran");
            DisplayAge(ages, "Jason");

            // Modifying elements in the dictionary
            AddOrUpdateAge(ages, "Jason", 33);
            DisplayAge(ages, "Cheryl");

            // Checking if a key exists and displaying age if it does
            DisplayAgeIfExists(ages, "Alice");
            DisplayAgeIfExists(ages, "Kieran");

            // Iterating over key-value pairs in the dictionary and displaying all ages
            DisplayAllAges(ages);

        }

        /// <summary>
        /// Method to add or update age in the dictionary.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static void AddOrUpdateAge(Dictionary<string, int> dictionary, string name, int age)
        {
            if (dictionary.ContainsKey(name))
            {
                // If name already exists, update the age
                dictionary[name] = age;
            }
            else
            {
                // If name doesn't excist, add it to the dictionary
                dictionary.Add(name, age);
            }
        }

        /// <summary>
        /// Method to display age for a given name
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="name"></param>
        static void DisplayAge(Dictionary<string, int> dictionary, string name)
        {
            int age;
            if (dictionary.TryGetValue(name, out age))
            {
                // If name exists, display its age
                Console.WriteLine($"{name}'s age: {age}");
            }
            else
            {
                // If name doesn't exist, inform the user
                Console.WriteLine($"{name} not found in the dictionary.");
            }
        }

        static void DisplayAgeIfExists(Dictionary<string, int> dictionary, string name)
        {
            if (dictionary.ContainsKey(name))
            {
                // If name exists, display its age
                DisplayAge(dictionary, name);
            }
            else
            {
                // If name doesn't exist, inform the user
                Console.WriteLine($"{name} not found in the dictionary.");
            }
        }

        /// <summary>
        /// Method to display all ages in the dictionary
        /// </summary>
        /// <param name="dictionary"></param>
        static void DisplayAllAges(Dictionary<string, int> dictionary)
        {
            Console.WriteLine("All ages:");
            foreach (KeyValuePair<string, int> pair in dictionary)
            {
                // Display each name and its corresponding age
                Console.WriteLine($"Name: {pair.Key}, Age: {pair.Value}");
            }
        }
    }
}
