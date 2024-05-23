using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDesignCountriesLab
{
    public class CountryListView //Create a CountryListView class. x
    {
        //properties
        public List<Country> Countries{ get; set; } 
       
        //constructor. This view will take a list of countries in its constructor. 
        public CountryListView()
        {
            

        }
        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i}. {Countries[i].Name}");
            }
        }
    }
}
