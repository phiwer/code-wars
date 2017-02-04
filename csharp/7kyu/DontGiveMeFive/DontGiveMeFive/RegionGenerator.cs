using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontGiveMeFive
{
    public class RegionGenerator
    {
        public RegionGenerator(int startNumber, int endNumber, int filteredNumber = 5)
        {
            this.StartNumber = startNumber;
            this.EndNumber = endNumber;
            this.FilteredNumber = filteredNumber;
        }

        public int StartNumber { get; protected set; }
        public int EndNumber { get; protected set; }
        public int FilteredNumber { get; protected set; }

        public IEnumerable<int> Values { get; protected set; }

        public void GenerateRegionValues()
        {
            var allRegionValues = GenerateValues(this.StartNumber, this.EndNumber);
            this.Values = FilterValues(allRegionValues, this.FilteredNumber);
        }

        private static IEnumerable<int> FilterValues(IEnumerable<int> allRegionValues, int filteredNumber)
        {
            return allRegionValues.Where(x => !x.ToString().Contains(filteredNumber.ToString())).AsEnumerable();
        }

        private static IEnumerable<int> GenerateValues(int startNumber, int endNumber)
        {
            return Enumerable.Range(startNumber, endNumber - startNumber + 1);
        }
    }
}
