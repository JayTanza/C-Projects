using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionRental
{
    internal class ChildrensMovie : Movie
    {
        //Derived class for a Children's Movie
        public ChildrensMovie(string title, int year) : base(title,year,2.0){ }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Category: Children's Movie");
        }

    }
}
