using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionRental
{
    internal class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public double RentalPrice { get; set; }

        public Movie(string title, int year, double rentalprice) {
            Title = title;
            Year = year;
            RentalPrice = rentalprice;
        }

        public virtual void DisplayInfo() {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Price: {RentalPrice}");
        }
    }
}
