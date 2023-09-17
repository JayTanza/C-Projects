using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArray_NestedForloop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Consonant();
            //LeftTriangle();
            //RightTriangle();
            //ArrayLogin();
            //ArraySearch();
        }

        static void RightTriangle() {
            Console.Write("Enter a row: ");
            string input = Console.ReadLine();
            int row = int.Parse(input);

            for (int i = 1; i <= row; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Consonant() {
            char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Consonant letters:");
            for (int i = 0; i < consonants.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(consonants[i]);
                }
                Console.WriteLine();
            }
        }
        static void LeftTriangle()
        {
            Console.Write("Enter a row: ");
            string input = Console.ReadLine();
            int row = int.Parse(input);
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = row; i >= 1; i--) {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void ArraySearch() {
            string[,] users = {
            {"David", "David123"},
            {"Alenere", "Alenere123"},
            {"Hazel", "Hazel123"},
            {"Jaymar", "Jaymar123"}
        };

            Console.WriteLine("Welcome to the User Management System");

            // Prompt the user for a new username and password
            Console.Write("Enter a new username: ");
            string newUsername = Console.ReadLine();

            Console.Write("Enter a new password: ");
            string newPassword = Console.ReadLine();

            // Check if the entered username already exists in the users array
            bool userExists = false;

            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (newUsername == users[i, 0])
                {
                    userExists = true;
                    break; // Exit the loop if a match is found
                }
            }

            // Add the new user if it doesn't already exist
            if (!userExists)
            {
                // Create a new array with one additional row to accommodate the new user
                int numRows = users.GetLength(0) + 1;
                string[,] newUsers = new string[numRows, 2];

                // Copy existing users to the new array
                for (int i = 0; i < users.GetLength(0); i++)
                {
                    newUsers[i, 0] = users[i, 0];
                    newUsers[i, 1] = users[i, 1];
                }

                // Add the new user to the new array
                newUsers[numRows - 1, 0] = newUsername;
                newUsers[numRows - 1, 1] = newPassword;

                // Replace the original users array with the new array
                users = newUsers;

                Console.WriteLine("New user added successfully.");
            }
            else
            {
                Console.WriteLine("Username already exists. User not added.");
            }
        }

        static void ArrayLogin() {
            string[] names = { "David", "Alenere", "Hazel", "Jaymar" };

            // 2D Array containing usernames and passwords
            string[,] users = {
                {"David", "David123"},
                {"Alenere", "Alenere123"},
                {"Hazel", "Hazel123"},
                {"Jaymar", "Jaymar123"}
            };

            Console.WriteLine("Welcome to the Simple Login System");

            // Prompt the user for username and password
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            // Check if the provided credentials match any entry in the users array
            bool isAuthenticated = false;

            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (username == users[i, 0] && password == users[i, 1])
                {
                    isAuthenticated = true;
                    break; // Exit the loop if a match is found
                }
            }

            // Display login status
            if (isAuthenticated)
            {
                Console.WriteLine("Login successful. Welcome, " + username + "!");
            }
            else
            {
                Console.WriteLine("Login failed. Invalid username or password.");
            }
        }
    }
}
