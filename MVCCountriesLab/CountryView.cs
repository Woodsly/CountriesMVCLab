using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryView
    {
        //property
        public Country displayCountry { get; set; }
        //constructor
        public CountryView(Country _displayCountry)
        {
            displayCountry = _displayCountry;
        }
        //method
        public void Display()
        {
            Console.WriteLine($"{displayCountry.Name} is in {displayCountry.Continent}");
            Console.WriteLine("Flag colors include: ");
            foreach (string c in displayCountry.Colors)
            {
                Console.WriteLine($"{c}");
            }
        }
    }
}
