using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace system.test
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void testing_children()
        {

            
            double total = 200;
            string children;


            Console.WriteLine("Do you have any children?");
            children = "yes";

            if ((children == "yes")) total *= 1.5;

            Assert.AreEqual(300, total);

        }
    }

}
