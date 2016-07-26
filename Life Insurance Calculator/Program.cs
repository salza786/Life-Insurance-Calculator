using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Life_Insurance_Calculator
{

    interface Life_Insurance
    {

    }

    class quote : Life_Insurance
    {



    }


    class menu
    {
        private string name, gender, location, smoking, children;
        private int age, hours_of_exerise, cost;
        private double total;
        List<quote> Life_Insurance = new List<quote>();

        // Declaration of variables

        public menu()
        {
            main_menu();
        }
        public void main_menu()
        {

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
                Console.Clear();
            Console.Clear();
            Console.WriteLine("Main Menu..\n");
            Console.WriteLine("Select option: ");
            Console.WriteLine("               ");
            Console.WriteLine("1. Get Life Insurance Quote \r\n");
            Console.WriteLine("               ");
            Console.WriteLine("0. Exit\r\n");


            int option = int.Parse(Console.ReadLine());
            switch (option)
            {

                case 0:
                    Environment.Exit(0);

                    break;

                // Menu UI to select get quote or exit program

                case 1://get quote info

                    Console.Clear();
                    Console.WriteLine("Quote Menu Menu\n");

                    Console.WriteLine("Please Enter Information\n");

                    Console.WriteLine("Enter First and SurName");
                    string name = Console.ReadLine();
                    Console.WriteLine("Specify Gender (male/female)");
                    string gender = Console.ReadLine();
                    Console.WriteLine("Enter Age");
                    int age = int.Parse(Console.ReadLine());

                    if (age > 0 && age <= 18)
                    {
                        switch (gender)
                        {
                            case "male":
                                total = 150;
                                break;
                            case "female":
                                total = 100;
                                break;
                        }
                    }
                    else if (age > 18 && age <= 24)
                    {
                        switch (gender)
                        {
                            case "male":
                                total = 180;
                                break;
                            case "female":
                                total = 165;
                                break;
                        }
                    }
                    else if (age > 24 && age < 35)
                    {
                        switch (gender)
                        {
                            case "male":
                                total = 200;
                                break;
                            case "female":
                                total = 180;
                                break;
                        }
                    }
                    else if (age >= 35 && age < 45)
                    {
                        switch (gender)
                        {
                            case "male":
                                total = 250;
                                break;
                            case "female":
                                total = 225;
                                break;
                        }
                    }
                    else if (age >= 45 && age < 60)
                    {
                        switch (gender)
                        {
                            case "male":
                                total = 320;
                                break;
                            case "female":
                                total = 315;
                                break;
                        }
                    }
                    else if (age >= 60)
                    {
                        switch (gender)
                        {
                            case "male":
                                total = 500;
                                break;
                            case "female":
                                total = 485;
                                break;
                        }
                    }

                    // established current total using inputted age and gender

                    Console.WriteLine("Enter Country of Location (England, Wales, Scotland, Ireland, Northern Ireland, Other)\r\n");
                    string location = Console.ReadLine();

                    switch (location)
                    {
                        case "England":
                            break;
                        case "Wales":
                            total -= 100;
                            break;
                        case "Scotland":
                            total += 200;
                            break;
                        case "Ireland":
                            total += 50;
                            break;
                        case "Northern Ireland":
                            total += 75;
                            break;
                        case "Other":
                            total += 100;
                            break;
                    }

                    // modify total depending on location of country staying in

                    Console.WriteLine("Do You Have Any Children? (yes/no)\r\n");
                    string children = Console.ReadLine();

                    if (children == "yes")
                        total *= 1.5;

                    // modify total depending on having children or not

                    Console.WriteLine("Are You A Smoker? (yes/no)\r\n");
                    string smoking = Console.ReadLine();
                    if (smoking == "yes")
                        total *= 3;

                    // modify total depending on smoking/non-smoking

                    Console.WriteLine("How Many Hours Do You Exercise Per Week?\r\n");
                    int hours_of_exercise = int.Parse(Console.ReadLine());
                    if (hours_of_exercise == 0)
                        total *= 1.2;
                    else if (hours_of_exercise >= 3 && hours_of_exercise <= 5)
                        total /= 1.3;
                    else if (hours_of_exercise >= 6 && hours_of_exercise <= 8)
                        total /= 1.50;
                    else if (hours_of_exercise >= 9)
                        total *= 1.5;

                    // modify total depending on hours of exercise done per week

                    if (total < 50)
                        total = 50;

                    // ensure any total below 50 equals 50

                    break;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Your insurance quote is: £" + Math.Round(total, 2)); // final output displaying final quote price
            main_menu();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            {

                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");
            Console.WriteLine("                                    x\n");
            Console.WriteLine("    Life Insurance Calculator       x\n");
            Console.WriteLine("    BGL GROUP                       x\n");
            Console.WriteLine("                                    x\n");
            Console.WriteLine("    Salman Fatmi                    x\n");
            Console.WriteLine("    Technology Graduate Programme   x\n");
            Console.WriteLine("    Press Esc for Main Menu         x\n");
            Console.WriteLine("                                    x\n");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");
            menu mainmenu = new menu();

            // main menu welcome page upon code execution 

        }
    }

}
