using System;
using System.Collections.ObjectModel;
using CountryWPF.Model.Interfaces;
using CountryWPF.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCountryWPF
{
    [TestClass]
    public class TestCountryViewModel
    {
        [TestMethod]
        public void LoadCountriesMethod_ShouldMakeCountries_WhenCalled()
        {
            CountryViewModel cvm = new CountryViewModel();
            ObservableCollection<ICountry> collection = new ObservableCollection<ICountry>();
            ObservableCollection<ICountry> collectionAfterLoad = new ObservableCollection<ICountry>();
            collectionAfterLoad = cvm.Countries;

            cvm.LoadCountries();

            Assert.AreNotEqual(collection, collectionAfterLoad);
        }
    }
}
