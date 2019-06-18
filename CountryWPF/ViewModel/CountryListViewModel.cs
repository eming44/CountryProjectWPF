using CountryWPF.Model;
using CountryWPF.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryWPF.ViewModel
{
    public class CountryListViewModel
    {
        public static ObservableCollection<ICountry> Countries
        {
            get
            {
                return CountriesDB.Countries;
            }
        }
    }
}
