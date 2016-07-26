using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace system.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testing_less_then_18_aged_male_quote_bass_price()
        {
         

            int total = 0;
            int age;
            string gender;
                   

            Console.WriteLine("Enter Age");
            Console.WriteLine("Enter Gender");
            age = 18;
            gender = "male";

            if ((gender == "male") && age <= 18) total = 150;

            Assert.AreEqual(150, total);

                }
            }

        }
 