using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionRental
{
    internal class RegularMovie : Movie
    {
        public RegularMovie(string title, int year) : base(title, year, 3.0) { }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Category: Regular Movie");
        }
    }
}
