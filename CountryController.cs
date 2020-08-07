using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryController
    {
        public List<Country> CountryDb { get; set; }

        public CountryController()
        {
            CountryDb.Add(new Country() { Name = "Germany", Continent = "Europe", Colors = [1] });
            // how to do get list  into list constructor. 
        }
        public void CountryAction(Country c)
        {
            CountryView v = new CountryView();
            
            v.Display(c);
            Console.WriteLine("Would you like to learn about another country?");
            
        }
        public void CountryList()
        {
            CountryListView v = new CountryListView();
            v.Display(CountryDb);
            Country c = v.GetUserSelection(CountryDb);


        }
        public void WelcomeAction()

        {
            Console.WriteLine("Hello welcome to the country app. Pleaseselect a country from the following list: ");
            CountryListView v = new CountryListView();
            v.Display(CountryDb);
            CountryList();
            
        }
        
    }
} // it would be really annoying if the show says oh wait they actually started the whole knot time travel paradox thing when they went back evne further in time to stop the intial reason for time travel to be created...
