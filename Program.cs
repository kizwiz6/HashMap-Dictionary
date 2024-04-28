namespace HashMap_Dictionary
{
    /// <summary>
    /// Main program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        static void Main(string[] args)
        {
            // Create an instance of the AgeTracker
            IAgeTracker ageTracker = new AgeTracker();

            // Adding elements to the dictionary
            ageTracker.AddOrUpdateAge("Kieran", 29);
            ageTracker.AddOrUpdateAge("James", 29);
            ageTracker.AddOrUpdateAge("John", 25);
            ageTracker.AddOrUpdateAge("Alice", 30);
            ageTracker.AddOrUpdateAge("Bob", 67);


            // Display ages for specific names
            Console.WriteLine($"Kieran's age: {ageTracker.GetAge("Kieran")}");
            Console.WriteLine($"James' age: {ageTracker.GetAge("James")}");
            Console.WriteLine($"John's age: {ageTracker.GetAge("John")}");
            Console.WriteLine($"Alice's age: {ageTracker.GetAge("Alice")}");
            Console.WriteLine($"Bob's age: {ageTracker.GetAge("Bob")}");

            // Display all names and ages stored in the tracker
            Console.WriteLine("\nAll ages:");
            foreach (var entry in ageTracker.GetAllAges())
            {
                Console.WriteLine($"Name: {entry.Key}, Age: {entry.Value}");
            }

        }
    }
}
