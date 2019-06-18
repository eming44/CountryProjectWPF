using CountryWPF.Assets;
using CountryWPF.Factories;
using CountryWPF.Model;
using CountryWPF.Model.Interfaces;
using CountryWPF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CountryWPF.ViewModel
{
    public class CountryViewModel
    {
        #region Fields
        private int currCountryIndex = 0;
        private List<int> deletedCountriesIndex = new List<int>();
        private ICountry currCountry = new CountryModel();
        private ObservableCollection<ICountry> countries = new ObservableCollection<ICountry>();
        #endregion

        #region Properties
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
        public ObservableCollection<ICountry> Countries
        {
            get
            {
                return CountriesDB.Countries;
            }
        }
        public MyICommand NextCommand { get; set; }
        public MyICommand PreviousCommand { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand UndoCommand { get; set; }
        #endregion

        #region Methods
        private void OnNext()
        {
            if (deletedCountriesIndex.Count < CountriesDB.Countries.Count)
            {
                do
                {
                    if (currCountryIndex == CountriesDB.Countries.Count - 1)
                    {
                        currCountryIndex = 0;
                    }
                    else if (currCountryIndex < CountriesDB.Countries.Count - 1)
                    {
                        currCountryIndex++;
                    }
                } while (CountriesDB.Countries[currCountryIndex].IsDeleted == true);

                ConvertInNewCountry();
            }
        }
        private void OnPrevious()
        {
            if (deletedCountriesIndex.Count < CountriesDB.Countries.Count)
            {
                do
                {
                    if (currCountryIndex == 0)
                    {
                        currCountryIndex = CountriesDB.Countries.Count - 1;
                    }
                    else if (currCountryIndex > 0)
                    {
                        currCountryIndex--;
                    }
                } while (CountriesDB.Countries[currCountryIndex].IsDeleted == true);

                ConvertInNewCountry();
            }
        }
        private bool CanNextOrPrevious()
        {
            return currCountry != null;
        }
        private void OnDelete()
        {
            if (deletedCountriesIndex.Count < CountriesDB.Countries.Count)
            {
                if(deletedCountriesIndex.Count + 1 == CountriesDB.Countries.Count
                    && MessageBox.Show($"Do you really want to delete {CountriesDB.Countries[currCountryIndex].CountryName}?", "Please select", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    deletedCountriesIndex.Add(currCountryIndex);
                    CountriesDB.Countries[currCountryIndex].IsDeleted = true;

                    ICountry test = CountryFactory.CreateEmptyCountry(@"Images\noImage.png");

                    CurrCountry.CountryName = test.CountryName;
                    CurrCountry.CapitalName = test.CapitalName;
                    CurrCountry.CountryInfo = test.CountryInfo;
                    CurrCountry.CountryFlag = test.CountryFlag;
                }
                else if (MessageBox.Show($"Do you really want to delete {CountriesDB.Countries[currCountryIndex].CountryName}?", "Please select", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    deletedCountriesIndex.Add(currCountryIndex);
                    CountriesDB.Countries[currCountryIndex].IsDeleted = true;
                    OnNext();
                }
            }
        }
        private void OnUndo()
        {
            if (deletedCountriesIndex.Count != 0)
            {
                currCountryIndex = deletedCountriesIndex[deletedCountriesIndex.Count - 1];
                CountriesDB.Countries[deletedCountriesIndex[deletedCountriesIndex.Count - 1]].IsDeleted = false;
                deletedCountriesIndex.RemoveAt(deletedCountriesIndex.Count - 1);
                ConvertInNewCountry();
            }
        }
        private void ConvertInNewCountry()
        {
            CurrCountry.CountryName = CountriesDB.Countries[currCountryIndex].CountryName;
            CurrCountry.CapitalName = CountriesDB.Countries[currCountryIndex].CapitalName;
            CurrCountry.CountryInfo = CountriesDB.Countries[currCountryIndex].CountryInfo;
            CurrCountry.CountryFlag = CountriesDB.Countries[currCountryIndex].CountryFlag;
        }
        public void LoadCountries()
        {
            ICountry italy = CountryFactory.CreateItaly();
            ICountry france = CountryFactory.CreateFrance();
            ICountry bulgaria = CountryFactory.CreateBulgaria();
            ICountry serbia = CountryFactory.CreateSerbia();
            ICountry germany = CountryFactory.CreateGermany();
            ICountry brazil = CountryFactory.CreateBrazil();

            countries.Add(italy);
            countries.Add(france);
            countries.Add(bulgaria);
            countries.Add(serbia);
            countries.Add(germany);
            countries.Add(brazil);

            CountriesDB.Countries = countries;

            ConvertInNewCountry();
        }
        public CountryViewModel()
        {
            LoadCountries();
            NextCommand = new MyICommand(OnNext, CanNextOrPrevious);
            PreviousCommand = new MyICommand(OnPrevious, CanNextOrPrevious);
            DeleteCommand = new MyICommand(OnDelete);
            UndoCommand = new MyICommand(OnUndo);
        }
        #endregion
    }
}
