using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace system.test
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void testing_smoking()
        {


            int total = 100;
            string smoking;


            Console.WriteLine("Are you a smoker?");
            smoking = "yes";
         
            if ((smoking == "yes")) total *= 3;

            Assert.AreEqual(300, total);

        }
    }

}
