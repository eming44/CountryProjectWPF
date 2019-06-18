using CountryWPF.Assets;
using CountryWPF.Factories;
using CountryWPF.Model;
using CountryWPF.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CountryWPF.ViewModel
{
    public class AddCountryViewModel
    {
        private ICountry currCountry = new CountryModel();

        public ICountry CurrCountry
        {
            get
            {
                return this.currCountry;
            }
            set
            {
                this.currCountry = value;
            }
        }
        public MyICommand SaveCommand { get; set; }

        private void OnSave()
        {
            if (currCountry.CountryName != ""
                && currCountry.CapitalName != ""
                && currCountry.CountryInfo != ""
                && currCountry.CountryPath != "")
            {
                ICountry country = CountryFactory.CreateEmptyCountry();

                country.CountryName = currCountry.CountryName;
                country.CapitalName = currCountry.CapitalName;
                country.CountryInfo = currCountry.CountryInfo;
                country.CountryPath = currCountry.CountryPath;

                CountriesDB.Countries.Add(country);
                //Countries.Add(country);

                currCountry = HelperFunction.ResetCountry(currCountry);

                MessageBox.Show($"Country added successfully!");
            }
        }
        public AddCountryViewModel()
        {
            SaveCommand = new MyICommand(OnSave);
        }
    }
}
