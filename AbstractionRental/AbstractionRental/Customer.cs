using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionRental
{
    internal class Customer 
    {
        private static int increCustomerID = 0;
        public string Name { get; set; }
        public int CustomerId { get; }
        public Movie RentedMovie { get; set; }

        public Customer(string name) { 
            Name = name;
            CustomerId = increCustomerID++;
        }
        public void RentMovie(Movie movie)
        {
            this.RentedMovie = movie;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Customer ID: {CustomerId}");

            if (RentedMovie != null)
            {
                Console.WriteLine($"Title: {RentedMovie.Title}");
                Console.WriteLine($"Year: {RentedMovie.Year}");
                Console.WriteLine($"Rental Price: ${RentedMovie.RentalPrice}");
            }
            else
            {
                Console.WriteLine("No movie rented.");
            }
        }

        //public void RentMovie(Movie movie)
        //{
        //    Console.WriteLine($"Customer ID: {CustomerId}");
        //    Console.WriteLine($"Customer Name: {Name}");
        //    movie.DisplayInfo();
        //    Console.WriteLine();
        //}
    }
}
