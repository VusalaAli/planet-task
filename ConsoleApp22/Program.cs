using Core.Data;
using Core.Helpers.Enums;
using Core.Models;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            bool f = false;
            string choice;
            string name;
            double area;
            string anthem;
            Region region;
            do
            {
                Console.WriteLine("1. Planet yarat 2.Planetleri gor 3.Country Session 0.Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        bool s;
                        Console.WriteLine("Planet adi daxil edin:");
                        name = Console.ReadLine();                                            
                        do
                        {
                            Console.WriteLine("Area daxil edin:");
                            s = false;
                            s = double.TryParse(Console.ReadLine(), out area);

                        } while (!s);

                        Planet planet = new Planet(name,area);
                        AppDbContext.CreatePlanet(planet);
                       break;
                                   
                    case "2":
                        List<Planet> planets = AppDbContext.GetAllPlanets ();
                        foreach (var item in planets)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "3":
                        bool d = false;
                        do
                        {
                            Console.WriteLine("1.Olke yarat 2.Olkeleri gor 3.Evvelki menuya qayit 0.Exit");
                            choice = Console.ReadLine();
                            switch(choice)
                            {
                                case "1":
                                    bool s2;
                                    Console.WriteLine("olke adi daxil edin:");
                                    name = Console.ReadLine();
                                    do
                                    {
                                        Console.WriteLine("Area daxil edin:");
                                        s2 = false;
                                        s2 = double.TryParse(Console.ReadLine(), out area);

                                    } while (!s2);
                                    Console.WriteLine("Himn  daxil edin:");
                                    anthem = Console.ReadLine();
                                reset:
                                    Console.WriteLine("Region secin");
                                    Console.WriteLine("1.Avropa 2.Asiya 3.SAmerika 4.CAmerika 5.Avstraliya");
                                    choice = Console.ReadLine();
                                    switch(choice)
                                    {
                                        case "1":
                                            region  = Region.Avropa;
                                            break;
                                        case "2":
                                            region = Region.Asiya;
                                            break;
                                        case "3":
                                            region = Region.SAmerika;
                                            break;
                                        case "4":
                                            region = Region.Asiya;
                                            break;
                                        case "5":
                                            region = Region.Avstraliya;
                                            break;
                                        default:
                                            goto reset;

                                    }
                                    Country country = new Country(name, area, anthem, region);
                                    break;
                                case "2":

                                    break;
                                case "3":

                                    break;
                                case "0":
                                    f = true;                                   
                                    break;
                                default:
                                    Console.WriteLine("Duzgun secim edin");
                                    break;


                            }
                            




                        } while (!d);
                        break;














                   case "0":
                        f = true;
                        break;
                   default:
                        Console.WriteLine("Duzgun secim edin");
                        break;
                }



            } while (!f);




            
        }
    }
}
