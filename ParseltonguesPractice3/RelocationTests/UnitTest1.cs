using NUnit.Framework;
using RelocationTests;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            string lineOne = "5 10";
            string lineTwo = "5 2 8 1 4";

            int numRequests;

            Implementation implementation = Implementation.GetImplementation(lineOne, lineTwo, out numRequests);

            implementation.Move(2, 10);
            Assert.AreEqual(3, implementation.Distance(4, 5));
            Assert.AreEqual(3, implementation.Distance(1, 3));
            implementation.Move(4, 3);
            Assert.AreEqual(1, implementation.Distance(1, 5));
            Assert.AreEqual(6, implementation.Distance(5, 2));
            implementation.Move(4, 1);
            Assert.AreEqual(9, implementation.Distance(2, 4));
            implementation.Move(3, 15);
            Assert.AreEqual(4, implementation.Distance(4, 1));
        }
    }
}