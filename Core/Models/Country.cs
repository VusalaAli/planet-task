using Core.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Country
    {
        static int _countryId = 1;
        public string Name;
        public double Area;
        public string Anthem;
        public Region regions;
        public int CountryId { get; set; }

        public Country(string name, double area, string anthem,Region region)
        {
            _countryId++;
            CountryId = _countryId;
            Name = name;
            Area = area;
            Anthem = anthem;
            regions = region;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine($"Country name:{Name},Country area:{Area},Country anthem:{Anthem},Region:{regions }");
        }
    }
}
