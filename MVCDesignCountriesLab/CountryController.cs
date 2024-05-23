using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDesignCountriesLab
{
    public class CountryController
    {
        //property
        List<Country> Countries = new List<Country>()
        {
            new Country("USA","North America"),
            new Country("Canada","North America"),
            new Country( "UK", "Europe"),
            new Country("France", "Europe"),
            new Country("Germany","Europe"),
            new Country("Japan", "Asia"),
            new Country( "China", "Asia"),
            new Country("India","Asia"),
            new Country("Brazil","South America"),
            new Country("Australia","Australia"),
        };
        
            
        //method
        Public void CountryAction(Country c)//This will take in a Country model x
        {
            //, passing the model into the CountryView
            //constructor, and call Display Country on your CountryView object. 
           // Country country = new Country();
            CountryView countryView = new CountryView(Country );
            DisplayCountry = Country;
            countryView.DisplayCountry();
        }
    public void WelcomeAction()
        {
            CountryListView countryListView = new CountryListView(Countries);
        }

    }

}
