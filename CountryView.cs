using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }
        
        public void Display(Country C)
        {
            Console.Clear();
            Console.WriteLine("This is where we display some Countries!: ");
            Console.WriteLine($"Country: {C.Name}");
            Console.WriteLine($"Is on this Continent: {C.Continent}");
            Console.WriteLine($"And I've just given this a random {C.Colors} ");
            Console.ReadKey();
        }
    }
}
