using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace A0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int max = A0.Program.max(1,5);
            Assert.AreEqual(max,5);
            max = A0.Program.max(4,-1);
            Assert.AreEqual(max,4);
        }
    }
}
