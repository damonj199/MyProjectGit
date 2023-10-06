using MyProject;
using NUnit.Framework;
using System.Security.Cryptography;

namespace MyProject.Test
{
    public class VkladTests
    {
        [Test]
        public static void AddVkladaTest()
        {
            int sum = 10000;
            int year = 1;
            int percent = 10;
            int expected = 11000; 

            int actual = Vklad.AddVklada();

            Assert.AreEqual(expected, actual);
        }
    }
}