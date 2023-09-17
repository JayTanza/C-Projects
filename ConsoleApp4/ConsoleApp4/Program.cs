using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static string[] usernames = new string[100]; // Array to store usernames
        static string[] passwords = new string[100]; // Array to store passwords
        static int userCount = 0; // Counter to keep track of the number of registered users

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Simple Login/Register System");
                Console.WriteLine("Number of users: "+userCount);
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Please select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Register();
                        break;

                    case "2":
                        Login();
                        break;

                    case "3":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        static void Register()
        {
            Console.Write("Enter a username: ");
            string username = Console.ReadLine();

            // Check if the username already exists
            if (Array.Exists(usernames, u => u == username))
            {
                Console.WriteLine("Username already exists. Please choose a different one.");
                return;
            }

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            // Store the username and password in the arrays
            usernames[userCount] = username;
            passwords[userCount] = password;
            userCount++;

            Console.WriteLine("Registration successful!");
        }

        static void Login()
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // Find the index of the username in the array
            int index = Array.FindIndex(usernames, u => u == username);

            // Check if the username exists and the password matches
            if (index != -1 && passwords[index] == password)
            {
                Console.WriteLine("Login successful! Welcome, " + username);
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
            }
        }
    }
}
