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
            return array1.Where(x => x.IsSubStringsOf(array2.AsEnumerable())).OrderBy(x => x).ToArray();
        }
    }

    static class StringExtensions
    {
        public static bool IsSubStringsOf(this string str, IEnumerable<string> strings)
        {
            return strings.Any(x => x.Contains(str));
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
