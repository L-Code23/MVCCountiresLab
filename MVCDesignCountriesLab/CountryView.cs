using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDesignCountriesLab
{
    public class CountryView //Next Create a CountryView Class x
    {
        //property
        public Country DisplayCountry { get; set; }//Public Country DisplayCountry x

        //constructor
        public CountryView (Country _country) //In the constructor require a Country be taken in and set to DisplayCountry x
        {
            DisplayCountry = _country;
        }

        //method
        public void Display() //Public void Display() - This method will print out the Name, Continent, and Colors of the Country DisplayCountry property x
        {
            Console.WriteLine($"Name: {DisplayCountry.Name} Continent: {DisplayCountry.Continent} Color: {DisplayCountry.Colors}");
        }

    }
}
