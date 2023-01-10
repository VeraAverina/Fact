namespace TestFact
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            long f0 = Fact. Program.Fact(0);
            Assert.That(1L, Is.EqualTo(f0));
        }

        [Test]
        public void Test2()
        {
            long f0 = Fact.Program.Fact(5);
            Assert.That(120L, Is.EqualTo(f0));
        }

        [Test]
        public void Test3()
        {
            Exception exc = null;
            try
            {
                long f0 = Fact.Program.Fact(-1);
            }
            catch (Exception ex){
                exc = ex;
            }
            Assert.IsNotNull(exc);
        }
    }
}