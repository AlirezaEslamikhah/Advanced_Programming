using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace A00.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool is_prime = A00.Program.get_prime(1,5);
            Assert.AreEqual(is_prime,false);
            is_prime = A00.Program.get_prime(1,4);
            Assert.AreEqual(is_prime,false);
        }
    }
}
