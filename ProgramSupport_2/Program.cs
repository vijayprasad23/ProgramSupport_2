using System;

namespace ProgramSupport_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that asks the user to enter their 
            //Personal details and output it to the screen

            //Ask for the First name, last name, age, address and phone#
            //Display this in a user friendly manner. 

            //Variable Declaration
            string firstName, lastName, address, phone;
            int age;

            //Description of the program...
            Console.Write("This program will get your personal details..\n\n");

            //user inputs
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter your address: ");
            address= Console.ReadLine();
            Console.Write("Enter your phone number: ");
            phone = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            //Display
            Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
            Console.Write("Your frist name is " + firstName);
            Console.WriteLine("\nYour last name is " + lastName);
            Console.WriteLine("Address is " + address);
            Console.WriteLine("Phone number is " + phone);
            Console.WriteLine("Your age is " + age);

            Console.Write("\n\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
