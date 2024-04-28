using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap_Dictionary
{
    /// <summary>
    /// Implement the age tracker interface
    /// </summary>
    public class AgeTracker : IAgeTracker
    {
        // Internal dictionary to store names and ages
        private readonly Dictionary<string, int> _ages = new Dictionary<string, int>();

        /// <summary>
        /// Method to
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddOrUpdateAge(string name, int age)
        {
            // Validate input: name cannot be null or empty, age cannot be negative
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }

            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative.", nameof(age));
            }

            // Add or update age in the dictionary
            _ages[name] = age;
        }

        /// <summary>
        /// Gets the age of a person.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int? GetAge(string name)
        {
            // Check if the name exists in the dictionary
            if (_ages.TryGetValue(name, out int age))
            {
                // If found return the age
                return age;
            }
            // If not found, return null
            return null;
        }

        /// <summary>
        /// Gets all the names and ages stored in the tracker.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException">An enumerable collection of key-value pairs rperesenting names and ages.</exception>
        public IEnumerable<KeyValuePair<string, int>> GetAllAges()
        {
            // Return all key-value pairs in the dictionary
            return _ages;
        }
    }
}
