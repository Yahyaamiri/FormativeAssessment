using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormativeAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a TODO list in a file on a given path then add a task, remove a task from list//
            string fileName = "C:\\Users\\yahya\\Desktop\\NZSE IT Technical support materials\\Programing project for progaming\\Praticedirectory\\upgrade.txt";

            while (true)
            {
                Console.WriteLine("*******************************************************************");
                Console.WriteLine("\nWelcome to our store!:");
                Console.WriteLine("1.Please! Enter your details, Name, Phone, Email and location: ?");
                Console.WriteLine("2. Do you want purchase a phone or upgrade? ");
                Console.WriteLine("3. we can upgrade your device");
                Console.WriteLine("5. Exit");
                Console.WriteLine("*********************************************************************");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Customerdetails(fileName);
                        break;
                    case "2":
                        Displayphone(fileName);
                        break;
                    case "3":
                        upgradeDevice(fileName);
                        break;
                    case "4":
                        Displayfile(fileName);
                        break;
                    case "5":
                        Console.WriteLine("goodbye!");
                        break;
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void Customerdetails(string fileName)
        {
            {
                {

                    string name, phone, email, location, result;
                    Console.WriteLine("Enter your name");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter your phone");
                    phone = Console.ReadLine();
                    Console.WriteLine("Enter your email");
                    email = Console.ReadLine();
                    Console.WriteLine("Enter your location");
                    location = Console.ReadLine();
                    result = name + phone + email + location;
                    Console.WriteLine("Customer's full details" + result);

                    {
                        Console.WriteLine("your details successfully added.");
                    }
                }
            }
        }
        static void Displayphone(string fileName)
        {

            string IPhone11, IPhone12, IPhone13, IPhone14, choice, Sort;

            Console.WriteLine("we have some Iphone models please choose: 1 to 4");
            Sort = Console.ReadLine();
            Console.WriteLine("We have Iphone 11");
            IPhone11 = Console.ReadLine();
            Console.WriteLine("We have Iphone 12");
            IPhone12 = Console.ReadLine();
            Console.WriteLine("We have Iphone 13");
            IPhone13 = Console.ReadLine();
            Console.WriteLine("We have Iphone 14");
            IPhone14 = Console.ReadLine();
            choice = IPhone11 + IPhone12 + IPhone13 + IPhone14;
            Console.WriteLine("Your choice is not in our range of sales" + choice);

        }

        static void upgradeDevice(string fileName)
        {

            string Samsung, Buy, IPhone11, IPhone6, prefer, options;
            Console.WriteLine(" for upgradingDevice please choose 1 to 4 to show the options available");
            options = Console.ReadLine();
            Console.WriteLine("We have Samsung mobiles");
            Samsung = Console.ReadLine();
            Console.WriteLine("We can Iphone 11 ");
            IPhone11 = Console.ReadLine();
            Console.WriteLine("We have Iphone 6 ");
            IPhone6 = Console.ReadLine();
            Console.WriteLine("We can but your mobile");
            Buy = Console.ReadLine();
            prefer = IPhone11 + Samsung + IPhone11 + IPhone6 + Buy;
            Console.WriteLine("For upgrading your device we the blew options" + prefer);


        }
        static void Displayfile(string fileName)
        {

            Console.Write("Enter the file path to read from: ");
            string readFilePath = Console.ReadLine();
            Displayfile(readFilePath);


        }
    }

}
        
    

