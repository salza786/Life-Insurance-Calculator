using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace system.test
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void location()
        {

            int total = 200;
            string location;

            Console.WriteLine("Enter Location");
            location = "Other";

            if ((location == "Other")) total += 100;

            Assert.AreEqual(300, total);

        }
    }

}
