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
    }
}