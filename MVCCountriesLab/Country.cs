using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountriesLab
{
    internal class Country
    {
        //properties
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors = new List<string>();
        //constructor
        public Country(string _name, string _continent, List<string> _colors)
        {
            Name = _name;
            Continent = _continent;
            Colors = _colors;
        }
    }
}
