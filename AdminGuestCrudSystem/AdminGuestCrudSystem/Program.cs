using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminGuestCrudSystem
{
    // Define an abstract class for User with basic properties and methods
    abstract class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public abstract void DisplayDetails();
    }

    // Define a Guest class that inherits from User
    class Guest : User
    {
        public string GuestInfo { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Guest Details - Username: {Username}, Password: {Password}, Info: {GuestInfo}");
        }
    }

    // Define an interface for Admin with methods to manage users
    interface IAdmin
    {
        void CreateUser(Guest[] users, string username, string password, string guestInfo);
        void UpdateUser(Guest[] users, string username, string guestInfo);
        void DeleteUser(Guest[] users, string username);
        void RetrieveUser(Guest[] users, string username);
    }

    // Implement the Admin class that implements the IAdmin interface
    class Admin : IAdmin
    {
        public void CreateUser(Guest[] users, string username, string password, string guestInfo)
        {
            // Check if the username already exists
            if (Array.Exists(users, user => user != null && user.Username == username))
            {
                Console.WriteLine("Username already exists. Please choose a different one.");
            }
            else
            {
                // Find an empty slot for the new user
                int emptyIndex = Array.FindIndex(users, user => user == null);
                if (emptyIndex != -1)
                {
                    users[emptyIndex] = new Guest { Username = username, Password = password, GuestInfo = guestInfo };
                    Console.WriteLine("User created successfully.");
                }
                else
                {
                    Console.WriteLine("User limit reached. Cannot create a new user.");
                }
            }
        }

        public void UpdateUser(Guest[] users, string username, string guestInfo)
        {
            Guest user = Array.Find(users, u => u != null && u.Username == username);
            if (user != null)
            {
                user.GuestInfo = guestInfo;
                Console.WriteLine("User information updated successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public void DeleteUser(Guest[] users, string username)
        {
            int index = Array.FindIndex(users, user => user != null && user.Username == username);
            if (index != -1)
            {
                users[index] = null;
                Console.WriteLine("User deleted successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public void RetrieveUser(Guest[] users, string username)
        {
            Guest user = Array.Find(users, u => u != null && u.Username == username);
            if (user != null)
            {
                user.DisplayDetails();
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Guest[] users = new Guest[10];
            Admin admin = new Admin();

            while (true)
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login as Guest");
                Console.WriteLine("3. Login as Admin");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a username: ");
                        string regUsername = Console.ReadLine();
                        Console.Write("Enter a password: ");
                        string regPassword = Console.ReadLine();
                        Console.Write("Enter your info: ");
                        string guestInfo = Console.ReadLine();
                        admin.CreateUser(users, regUsername, regPassword, guestInfo);
                        break;

                    case 2:
                        Console.Write("Enter your username: ");
                        string guestUsername = Console.ReadLine();
                        Console.Write("Enter your password: ");
                        string guestPassword = Console.ReadLine();
                        Guest guest = Array.Find(users, user =>
                            user != null && user.Username == guestUsername && user.Password == guestPassword);
                        if (guest != null)
                        {
                            Console.WriteLine("Login successful as Guest.");
                            guest.DisplayDetails();
                        }
                        else
                        {
                            Console.WriteLine("Invalid username or password.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter your username (admin): ");
                        string adminUsername = Console.ReadLine();
                        Console.Write("Enter your password (admin): ");
                        string adminPassword = Console.ReadLine();
                        if (adminUsername == "admin" && adminPassword == "adminpass")
                        {
                            Console.WriteLine("Login successful as Admin.");
                            Console.WriteLine("1. Update User Info");
                            Console.WriteLine("2. Delete User");
                            Console.WriteLine("3. Retrieve User Info");
                            Console.WriteLine("4. Logout");
                            Console.Write("Enter your choice: ");
                            int adminChoice = int.Parse(Console.ReadLine());
                            switch (adminChoice)
                            {
                                case 1:
                                    Console.Write("Enter the username to update info: ");
                                    string updateUsername = Console.ReadLine();
                                    Console.Write("Enter the new info: ");
                                    string newInfo = Console.ReadLine();
                                    admin.UpdateUser(users, updateUsername, newInfo);
                                    break;

                                case 2:
                                    Console.Write("Enter the username to delete: ");
                                    string deleteUsername = Console.ReadLine();
                                    admin.DeleteUser(users, deleteUsername);
                                    break;

                                case 3:
                                    Console.Write("Enter the username to retrieve: ");
                                    string retrieveUsername = Console.ReadLine();
                                    admin.RetrieveUser(users, retrieveUsername);
                                    break;

                                case 4:
                                    Console.WriteLine("Admin logged out.");
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid username or password.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Exiting the application.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }

}
