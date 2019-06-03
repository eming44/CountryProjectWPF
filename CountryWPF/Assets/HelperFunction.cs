using CountryWPF.Factories;
using CountryWPF.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryWPF.Assets
{
    public class HelperFunction
    {
        public static ICountry ResetCountry(ICountry country)
        {
            ICountry reset = CountryFactory.CreateEmptyCountry();

            country.CountryName = reset.CountryName;
            country.CapitalName = reset.CapitalName;
            country.CountryInfo = reset.CountryInfo;
            country.CountryPath = reset.CountryPath;

            return reset;
        }
    }
}
