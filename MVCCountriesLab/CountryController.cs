using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryController
    {
        //properties
        public List<Country> CountryDb = new List<Country>()
        {
            new Country("United States", "North America", new List<string> {"red", "white", "blue"}),
            new Country("Russia", "Europe", new List<string> {"white", "blue", "red"}),
            new Country("South Africa", "Africa", new List<string> {"green", "yellow", "white", "red", "blue", "black"}),
            new Country("Australia", "Oceania", new List<string> {"red", "white", "blue"}),
            new Country("Iceland", "Europe", new List<string> {"red", "white", "blue"}),
            new Country("Kazakhstan", "Asia", new List<string> {"cyan", "yellow"}),
            new Country("Spain", "Europe", new List<string> {"red", "yellow"}),
        };
        //constructor
        public CountryController()
        {

        }
        //methods
        public void CountryAction(Country c)
        {
            CountryView con = new CountryView(c);
            con.Display();
        }
        public void WelcomeAction()
        {
            bool Yeehaw = true;
            while (Yeehaw)
            {
                CountryListView con = new CountryListView(CountryDb);
                Console.WriteLine($"Hello, welcome to the country app.  Please select a country from the following list: ");
                con.Display();
                Console.WriteLine("Please select the index of the country you would like to learn more about.");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > CountryDb.Count-1)
                {
                    Console.WriteLine("That was not an in range index... try again");
                }
                CountryAction(CountryDb[choice]);
                Yeehaw = Validator.Validator.GetContinue("Learn about another country?", "Yes", "No");
            }
            Console.WriteLine("Thanks for using the Country info database.");
        }
    }
}