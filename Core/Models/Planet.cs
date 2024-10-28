using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Planet
    {
        static int _planetId=1;
        public string Name;
        public double Area;
        public int PlanetId { get; set; }

        public  Planet( string name, double area)
        {
            _planetId++;
            PlanetId = _planetId;
            Name = name;
            Area = area;
        }
        public string ShowInfo()
        {
           return $"Planet Name:{Name},Planet Area:{Area}";
        }

        public override string ToString()
        {
            return ShowInfo() ; 
        }
    }
}
