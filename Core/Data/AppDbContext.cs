using Core.Helpers.Enums;
using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public static  class AppDbContext
    {
        static List<Planet> planets = new List<Planet>();
        static List<Country> countries = new List<Country>();


        public static void CreateCountry(Country country)
        {
            countries .Add(country);
        }
        public static void RemoveCountry(Country country)
        {
            countries .Remove(country);
        }
        public static Country UpdateCountry(int? id , string name)
        {
           Country fCountry;
           fCountry =  countries.Find(x => x.CountryId  == id);

            
            fCountry.Name = name;
            
            return fCountry;

        }
        public static List<Country> GetAllCountries()
        {
            return countries;
        }
        public static List<Country> GetCountryByRegion(Region region)
        {
            List<Country> fCountry;
            fCountry = countries.FindAll(x => x.regions== region);
            return fCountry;

        }
        public static void CreatePlanet(Planet planet)
        {
            planets.Add(planet);


        }
        public static void RemovePlanet(Planet planet )
        {
            planets.Remove(planet);
        }
        public static Planet UpdatePlanet(int? id ,string name)
        {
            Planet fPlanet;
            fPlanet = planets.Find(x => x.PlanetId== id);


            fPlanet.Name = name;

            return fPlanet;
        }
        public static List<Planet> GetAllPlanets()
        {
            return planets;
        }
        




    }
}
