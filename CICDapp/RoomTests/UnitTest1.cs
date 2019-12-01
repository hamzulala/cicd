using ExampleWebApplication.Models;
using NUnit.Framework;

namespace Tests
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
            Assert.Pass();
        }

        [Test]
        public void DefaultGetInfoTest()
        {
            Room r1 = new Room();
            Assert.AreEqual("TD224 - 22", r1.getInfo());
        }

        [TestCase(315, "TB", 10)]
        [TestCase(305, "TD", 25)]
        [TestCase(315, "TB", 10)]
        public void GetInfoTest(int n, string b, int c)
        {
            Room r1 = new Room(n, b, c);
            Assert.AreEqual($"{b}{n} - {c}", r1.getInfo());
        }
    }
}