using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbstractionRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rental();
            RentalCrud();

        }
        
        static void Rental()
        {
            //Create movies
            Movie movie1 = new ChildrensMovie("Toy Story", 1995);
            Movie movie2 = new RegularMovie("Ävengers EndGame", 2018);
            Movie movie3 = new NewReleaseMovie("MoonFall", 2022);

            // Create customers
            Customer customer1 = new Customer("Alice");
            Customer customer2 = new Customer("Jay");
            Customer customer3 = new Customer("Tony");

            // Rent movies
            customer1.RentMovie(movie1);
            customer2.RentMovie(movie2);
            customer3.RentMovie(movie3);
        }

        static void RentalCrud()
        {
            Customer[] customers = new Customer[100];
            Movie[] movies = new Movie[100];

            int customerCount = 0;

            int option;

            do
            {
                Console.WriteLine("CRUD Operations Menu:");
                Console.WriteLine("1. Rent a Movie");
                Console.WriteLine("2. Display customer who rented");
                Console.WriteLine("3. Update your rent");
                Console.WriteLine("4. Delete your rent");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1: // Rent
                        if (customerCount < customers.Length)
                        {
                            Console.Write("Enter name: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("Choose a Movie:");
                            Console.WriteLine("1. Toy Story");
                            Console.WriteLine("2. Avengers Endgame");
                            Console.WriteLine("3. Moon Fall");
                            Console.WriteLine("4. Exit");
                            Console.Write("Enter your choice: ");
                            int option2 = int.Parse(Console.ReadLine());

                            Movie selectedMovie = null;

                            switch (option2)
                            {
                                case 1:
                                    selectedMovie = new ChildrensMovie("Toy Story", 1995);
                                    break;
                                case 2:
                                    selectedMovie = new RegularMovie("Avengers Endgame", 2019);
                                    break;
                                case 3:
                                    selectedMovie = new NewReleaseMovie("Moon Fall", 2022);
                                    break;
                                case 4:
                                    Console.WriteLine("Exiting movie selection.");
                                    break;
                                default:
                                    Console.WriteLine("Invalid movie choice.");
                                    break;
                            }

                            if (selectedMovie != null)
                            {
                                Customer newCustomer = new Customer(name);
                                newCustomer.RentMovie(selectedMovie);
                                customers[customerCount] = newCustomer;
                                customerCount++;
                                Console.WriteLine("Customer rented successfully!");
                            }
                        }
                        break;
                    case 2: // Retrieve or Display
                        Console.WriteLine("===========================================");
                        Console.WriteLine("List of customers who rented movies: ");
                        Console.WriteLine("===========================================");
                        bool foundCustomersWithRentals = false; // Flag to check if any customers with rentals were found
                        for (int i = 0; i < customerCount; i++)
                        {
                            foundCustomersWithRentals = true;
                            Console.WriteLine($"ID: {i}\nName: {customers[i].Name}\nCustomerId: {customers[i].CustomerId}\nTitle: {customers[i].RentedMovie.Title}\nYear: {customers[i].RentedMovie.Year}\nRental Price: {customers[i].RentedMovie.RentalPrice} pesos");
                            Console.WriteLine("===========================================");
                        }

                        if (!foundCustomersWithRentals)
                        {
                            Console.WriteLine("No customers have rented movies.");
                        }
                       
                            break;
                    case 3: // Update your rent
                            // Implement code for updating a rental (if needed)
                        break;
                    case 4: // Delete your rent
                            // Implement code for deleting a rental (if needed)
                        break;
                    case 5: // Exit
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } while (option != 5);
        }
    }
}
