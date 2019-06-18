using CountryWPF.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryWPF.Model
{
    public static class CountriesDB
    {
        public static ObservableCollection<ICountry> Countries { get; set; }
    }
}
