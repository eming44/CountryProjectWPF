using CountryWPF.Assets;
using CountryWPF.Factories;
using CountryWPF.Model.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCountryWPF
{
    [TestClass]
    public class TestHelperFunction
    {
        [TestMethod]
        public void ResetCountryMethod_ShouldResetCountries_WhenCalled()
        {
            ICountry italy = CountryFactory.CreateItaly();

            italy = HelperFunction.ResetCountry(italy);

            Assert.AreEqual(italy.CountryName, "");
            Assert.AreEqual(italy.CapitalName, "");
            Assert.AreEqual(italy.CountryInfo, "");
            Assert.AreEqual(italy.CountryPath, "");
        }
    }
}
