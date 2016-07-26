using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace system.test
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void round_to_50()
        {

            int total = 100;

            int age;
            string location;

            Console.WriteLine("Age");
            Console.WriteLine("Enter Location");

            age = 16;
            location = "Wales";

            if ((age <= 18 && location == "Wales")) total -= 100;

            if (total < 50) total = 50;

            Assert.AreEqual(50, total);

        }
    }

}
