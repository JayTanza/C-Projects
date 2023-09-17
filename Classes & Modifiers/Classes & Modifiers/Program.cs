using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the Registration and Login classes
            Register register = new Register();
            Login login = new Login();

            Console.WriteLine("Welcome to the Login and Registration System!");

            // Registration Process
            Console.Write("Enter a username: ");
            string newUsername = Console.ReadLine();

            Console.Write("Enter a password: ");
            string newPassword = Console.ReadLine();

            User newUser = register.CreateUser(newUsername, newPassword);
            Console.WriteLine("Registration successful!");

            // Login Process
            Console.Write("Enter your username: ");
            string enteredUsername = Console.ReadLine();

            Console.Write("Enter your password: ");
            string enteredPassword = Console.ReadLine();

            if (login.Authenticate(newUser, enteredPassword))
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Login failed. Incorrect username or password.");
            }
        }
    }
}
