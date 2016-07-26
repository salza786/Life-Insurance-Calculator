using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace system.test
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void testing_hours_of_exercise()
        {
           
            double total = 200;
            int hours_of_exercise;

            Console.WriteLine("hours of exercise per week?");
            hours_of_exercise = 4;

            if (( hours_of_exercise >= 3 && hours_of_exercise <= 5)) total *= 0.7;

            Assert.AreEqual(140, total);

        }
    }

}
