using System;
using System.Collections.ObjectModel;
using CountryWPF.Factories;
using CountryWPF.Model.Interfaces;
using CountryWPF.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCountryWPF
{
    [TestClass]
    public class TestCountryFactory
    {
        [TestMethod]
        public void CreateItalyMethod_ShouldMakeItaly_WhenCalled()
        {
            ICountry italy = CountryFactory.CreateItaly();

            Assert.AreEqual(italy.CountryName, "Italy");
            Assert.AreEqual(italy.CapitalName, "Rome");
            Assert.AreEqual(italy.CountryInfo, 
            "Official languages: Italian\n" +
            "Government: Unitary parliamentary republic\n" +
            "Area: 301,340 km2\n" +
            "Population: 60,483,973");
            Assert.AreEqual(italy.CountryPath, @"Images\Countries\italy.png");
        }

        [TestMethod]
        public void CreateFranceMethod_ShouldMakeFrance_WhenCalled()
        {
            ICountry france = CountryFactory.CreateFrance();

            Assert.AreEqual(france.CountryName, "France");
            Assert.AreEqual(france.CapitalName, "Paris");
            Assert.AreEqual(france.CountryInfo, 
            "Official languages: French\n" +
            "Government: Unitary semi‑presidential republic\n" +
            "Area: 640,679 km2\n" +
            "Population: 67,348,000");
            Assert.AreEqual(france.CountryPath, @"Images\Countries\france.png");
        }

        [TestMethod]
        public void CreateBulgariaMethod_ShouldMakeBulgaria_WhenCalled()
        {
            ICountry bulgaria = CountryFactory.CreateBulgaria();

            Assert.AreEqual(bulgaria.CountryName, "Bulgaria");
            Assert.AreEqual(bulgaria.CapitalName, "Sofia");
            Assert.AreEqual(bulgaria.CountryInfo,
            "Official languages: Bulgarian\n" +
            "Government: Unitary parliamentary republic\n" +
            "Area: 110,993.6 km2\n" +
            "Population: 7,050,034");
            Assert.AreEqual(bulgaria.CountryPath, @"Images\Countries\bulgaria.png");
        }

        [TestMethod]
        public void CreateSerbiaMethod_ShouldMakeSerbia_WhenCalled()
        {
            ICountry serbia = CountryFactory.CreateSerbia();

            Assert.AreEqual(serbia.CountryName, "Serbia");
            Assert.AreEqual(serbia.CapitalName, "Belgrade");
            Assert.AreEqual(serbia.CountryInfo,
            "Official languages: Serbian\n" +
            "Government: Unitary parliamentary constitutional republic\n" +
            "Area: 88,361 km2\n" +
            "Population: 7,001,444");
            Assert.AreEqual(serbia.CountryPath, @"Images\Countries\serbia.png");
        }

        [TestMethod]
        public void CreateGermanyMethod_ShouldMakeGermany_WhenCalled()
        {
            ICountry germany = CountryFactory.CreateGermany();

            Assert.AreEqual(germany.CountryName, "Germany");
            Assert.AreEqual(germany.CapitalName, "Berlin");
            Assert.AreEqual(germany.CountryInfo,
            "Official languages: German\n" +
            "Government: Federal parliamentary republic\n" +
            "Area: 357,386 km2\n" +
            "Population: 83,000,000");
            Assert.AreEqual(germany.CountryPath, @"Images\Countries\germany.png");
        }

        [TestMethod]
        public void CreateBrazilMethod_ShouldMakeBrazil_WhenCalled()
        {
            ICountry brazil = CountryFactory.CreateBrazil();

            Assert.AreEqual(brazil.CountryName, "Brazil");
            Assert.AreEqual(brazil.CapitalName, "Brasilia");
            Assert.AreEqual(brazil.CountryInfo,
            "Official languages: Brazilian\n" +
            "Government: Federal presidential constitutional republic\n" +
            "Area: 8,515,767 km2\n" +
            "Population: 210,147,125");
            Assert.AreEqual(brazil.CountryPath, @"Images\Countries\brazil.png");
        }

        [TestMethod]
        public void CreateEmptyCountryWithoutParameterMethod_ShouldMakeEmptyCountry_WhenCalled()
        {
            ICountry emptyCountry = CountryFactory.CreateEmptyCountry();

            Assert.AreEqual(emptyCountry.CountryName, "");
            Assert.AreEqual(emptyCountry.CapitalName, "");
            Assert.AreEqual(emptyCountry.CountryInfo, "");
            Assert.AreEqual(emptyCountry.CountryPath, "");
        }

        [TestMethod]
        public void CreateEmptyCountryWithParameterMethod_ShouldMakeNoNEmptyCountry_WhenCalled()
        {
            ICountry emptyCountry = CountryFactory.CreateEmptyCountry(@"\Images\Countries\italy.png");

            Assert.AreEqual(emptyCountry.CountryName, "");
            Assert.AreEqual(emptyCountry.CapitalName, "");
            Assert.AreEqual(emptyCountry.CountryInfo, "");
            Assert.AreEqual(emptyCountry.CountryPath, @"\Images\Countries\italy.png");
        }
    }
}
