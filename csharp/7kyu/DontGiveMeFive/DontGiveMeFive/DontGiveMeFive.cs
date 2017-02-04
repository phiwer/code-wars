using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontGiveMeFive
{
    using System.Globalization;

    public class Kata
    {
        public static int DontGiveMeFive(int start, int end)
        {
            IEnumerable<int> region = GenerateRegion(start, end);

            int valueFilter = 5;
            region = FilterRegion(region, valueFilter);

            return region.Count();
        }

        public static IEnumerable<int> FilterRegion(IEnumerable<int> region, int valueFilter)
        {
            return region.Where(x => !x.ToString().Contains(valueFilter.ToString())).AsEnumerable();
        }

        public static IEnumerable<int> GenerateRegion(int start, int end)
        {
            if (start > end)
            {
                Swap(ref start, ref end);
            }

            return Enumerable.Range(start, end - start + 1);
        }

        private static void Swap(ref int start , ref int end)
        {
            int tmp = start;
            start = end;
            end = tmp;
        }
    }
}
