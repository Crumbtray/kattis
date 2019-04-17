using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilipTests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow("734 893", "437")]
        [DataRow("221 231", "132")]
        [DataRow("839 237", "938")]

        public void TestMethod1(string input, string result)
        {
            string compareResult = FilipImplementation.Compare(input);
            Assert.AreEqual(result, compareResult);
        }
    }
}
