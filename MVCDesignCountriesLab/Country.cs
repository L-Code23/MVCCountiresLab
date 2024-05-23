using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDesignCountriesLab
{
    //Model---------------------------------------------------
    public class Country
    {
        //properties
        public string Name {  get; set; }
        public string Continent {  get; set; }
        public List<string> Colors;

        //constructors
        public Country(string _name, string  _continent ) 
        {
            Name = _name;
            Continent = _continent;
        }
    }
}
