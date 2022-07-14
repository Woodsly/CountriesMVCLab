using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class CountryListView
    {
        //property
        public List<Country> Countries;
        //constructor
        public CountryListView(List<Country> _countries)
        {
            Countries = new List<Country>();
            Countries = _countries;
        }
        //methods
        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i}. {Countries[i].Name}");
            }
        }
    }
}
