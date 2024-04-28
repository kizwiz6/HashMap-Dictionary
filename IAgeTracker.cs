using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap_Dictionary
{
    public interface IAgeTracker
    {
        void AddOrUpdateAge(string name, int age);
        int? GetAge(string name);
        IEnumerable<KeyValuePair<string, int>> GetAllAges();
    }
}
