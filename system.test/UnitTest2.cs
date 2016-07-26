using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace system.test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void testing_less_then_18_aged_female_quote_bass_price()
        {


            int total = 0;
            int age;
            string gender;


            Console.WriteLine("Enter Age");
            Console.WriteLine("Enter Gender");
            age = 18;
            gender = "female";

            if ((gender == "female") && age <= 18) total = 100;

            Assert.AreEqual(100, total);

        }
    }

}
