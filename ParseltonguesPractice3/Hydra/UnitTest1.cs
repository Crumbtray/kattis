using HydraSubmission;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [TestCase(3, 3, 9)]
        [TestCase(1, 1, 3)]
        [TestCase(5, 0, -1)]
        [TestCase(1, 0, -1)]
        public void TestHydra(int heads, int tails, int expect)
        {
            Assert.AreEqual(expect, Program.KillHydra(heads, tails));
        }
    }
}