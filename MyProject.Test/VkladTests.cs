using MyProject;
using NUnit.Framework;
using System.Security.Cryptography;

namespace MyProject.Test
{
    public class VkladTests
    {
        [Test]
        public void AddVkladaTest()
        {
            int a = 10000;
            int b = 1;
            int c = 10;
            int expected = 11000; 

            int actual = Vklad.AddVklada();

            Assert.AreEqual(expected, actual);
        }
    }
}