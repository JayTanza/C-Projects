using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionRental
{
    internal class NewReleaseMovie : Movie
    {
        public NewReleaseMovie(string title, int year) : base(title, year, 4.0) { }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Category: New Release Movie");
        }
    }
}
