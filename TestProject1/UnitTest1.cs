using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Actor ator = new Actor();
            ator.Insert(new Actor { Nome = "a" });
            
            var r1 = Actor.Actores.Count;

            Assert.AreEqual(r1, 1);
        }
    }
}
