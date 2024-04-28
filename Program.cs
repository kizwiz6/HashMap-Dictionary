namespace HashMap_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a dictionary to store <key, value> pairs
            Dictionary<string, int> ages = new Dictionary<string, int>();

            // Adding elements to the dictionary
            ages["Kieran"] = 29;
            ages.Add("James", 29);
            ages["Jason"] = 32;
            ages.Add("Cheryl", 26);

            // Accessing elements in the dictionary
            Console.WriteLine("Kieran's age " + ages["Kieran"]);

            // Modifying elements in the dictionary
            ages["Jason"] = 33;
            Console.WriteLine("Jason's updated age: " + ages["Jason"]);

            // Checking if a key exists
            string name = "James";
            if (ages.ContainsKey(name))
            {
                Console.WriteLine(name + "'s age: " + ages[name]);
            }
            else
            {
                Console.WriteLine(name + " not found in the dictionary.");
            }

            // Iterating over key-value pairs in the dictionary
            foreach (KeyValuePair<string, int> pair in ages)
            {
                Console.WriteLine("Name: " + pair.Key + ", Age: " + pair.Value);
            }

        }


    }
}
