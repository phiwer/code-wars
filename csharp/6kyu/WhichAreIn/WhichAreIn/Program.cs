using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichAreIn
{
    using NUnit.Framework;

    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            var subStringsOfStrings = new SortedSet<string>();
            // your code
            foreach (var subString in array1)
            {
                //if(IsSubStringOf())
                if (array2.Where(x => x.Contains(subString)).Any())
                {
                    subStringsOfStrings.Add(subString);
                }
            }
            return subStringsOfStrings.ToArray();
        }
    }

    [TestFixture]
    public class WhichAreInTests
    {

        [Test]
        public void Test1()
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
    }

}
