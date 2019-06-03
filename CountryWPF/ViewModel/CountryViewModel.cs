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
        public static ObservableCollection<ICountry> Countries { get; set; }
        public MyICommand SaveCommand { get; set; }
        public MyICommand NextCommand { get; set; }
        public MyICommand PreviousCommand { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand UndoCommand { get; set; }
        #endregion

        #region Methods

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

                Countries.Add(country);

                //Countries = countries;

                currCountry = HelperFunction.ResetCountry(currCountry);

                MessageBox.Show($"Country added successfully!");
            }
        }
        private void OnNext()
        {
            if (deletedCountriesIndex.Count < Countries.Count)
            {
                do
                {
                    if (currCountryIndex == Countries.Count - 1)
                    {
                        currCountryIndex = 0;
                    }
                    else if (currCountryIndex < Countries.Count - 1)
                    {
                        currCountryIndex++;
                    }
                } while (Countries[currCountryIndex].IsDeleted == true);

                ConvertInNewCountry();
            }
        }
        private void OnPrevious()
        {
            if (deletedCountriesIndex.Count < Countries.Count)
            {
                do
                {
                    if (currCountryIndex == 0)
                    {
                        currCountryIndex = Countries.Count - 1;
                    }
                    else if (currCountryIndex > 0)
                    {
                        currCountryIndex--;
                    }
                } while (Countries[currCountryIndex].IsDeleted == true);

                ConvertInNewCountry();
            }
        }
        private bool CanNextOrPrevious()
        {
            return currCountry != null;
        }
        private void OnDelete()
        {
            if (deletedCountriesIndex.Count < Countries.Count)
            {
                if(deletedCountriesIndex.Count + 1 == Countries.Count
                    && MessageBox.Show($"Do you really want to delete {Countries[currCountryIndex].CountryName}?", "Please select", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    deletedCountriesIndex.Add(currCountryIndex);
                    Countries[currCountryIndex].IsDeleted = true;

                    ICountry test = CountryFactory.CreateEmptyCountry(@"Images\noImage.png");

                    CurrCountry.CountryName = test.CountryName;
                    CurrCountry.CapitalName = test.CapitalName;
                    CurrCountry.CountryInfo = test.CountryInfo;
                    CurrCountry.CountryFlag = test.CountryFlag;
                }
                else if (MessageBox.Show($"Do you really want to delete {Countries[currCountryIndex].CountryName}?", "Please select", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    deletedCountriesIndex.Add(currCountryIndex);
                    Countries[currCountryIndex].IsDeleted = true;
                    OnNext();
                }
            }
        }
        private void OnUndo()
        {
            if (deletedCountriesIndex.Count != 0)
            {
                currCountryIndex = deletedCountriesIndex[deletedCountriesIndex.Count - 1];
                Countries[deletedCountriesIndex[deletedCountriesIndex.Count - 1]].IsDeleted = false;
                deletedCountriesIndex.RemoveAt(deletedCountriesIndex.Count - 1);
                ConvertInNewCountry();
            }
        }
        private void ConvertInNewCountry()
        {
            CurrCountry.CountryName = Countries[currCountryIndex].CountryName;
            CurrCountry.CapitalName = Countries[currCountryIndex].CapitalName;
            CurrCountry.CountryInfo = Countries[currCountryIndex].CountryInfo;
            CurrCountry.CountryFlag = Countries[currCountryIndex].CountryFlag;
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

            Countries = countries;

            ConvertInNewCountry();
        }
        public CountryViewModel()
        {
            LoadCountries();
            NextCommand = new MyICommand(OnNext, CanNextOrPrevious);
            PreviousCommand = new MyICommand(OnPrevious, CanNextOrPrevious);
            DeleteCommand = new MyICommand(OnDelete);
            UndoCommand = new MyICommand(OnUndo);
            SaveCommand = new MyICommand(OnSave);
        }
        #endregion
    }
}
