using System;
using System.Collections.Generic;
using System.Globalization;
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
                string color = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(c);
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(color);
                if (color == "Black")
                {
                    Console.BackgroundColor = ConsoleColor.White;

                }
                Console.WriteLine($"{c}");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
