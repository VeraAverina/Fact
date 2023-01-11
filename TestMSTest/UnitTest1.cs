namespace TestMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            long f0 = Fact.Program.Fact(0);
            Assert.AreEqual(1L,f0);
        }
        [TestMethod]
        public void TestMethod2()
        {
            long f0 = Fact.Program.Fact(5);
            Assert.AreEqual(120L, f0);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Exception exc = null;
            try
            {
                long f0 = Fact.Program.Fact(-1);
            }
            catch (Exception ex)
            {
                exc = ex;
            }
            Assert.IsNotNull(exc);
        }
    }
}