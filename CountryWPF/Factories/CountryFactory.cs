using CountryWPF.Model;
using CountryWPF.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace CountryWPF.Factories
{
    public class CountryFactory
    {
        public static ICountry CreateItaly()
        {
            string countryName = "Italy";
            string capitalName = "Rome";
            string territoryInfo =
            "Official languages: Italian\n" +
            "Government: Unitary parliamentary republic\n" +
            "Area: 301,340 km2\n" +
            "Population: 60,483,973";
            string countryPath = @"Images\Countries\italy.png";

            IUnityContainer container = new UnityContainer();
            container.RegisterType<CountryModel>();

            CountryModel country = container.Resolve<CountryModel>();
            country.CountryName = countryName;
            country.CapitalName = capitalName;
            country.CountryInfo = territoryInfo;
            country.CountryPath = countryPath;

            return country;
        }
        public static ICountry CreateFrance()
        {
            string countryName = "France";
            string capitalName = "Paris";
            string territoryInfo =
            "Official languages: French\n" +
            "Government: Unitary semi‑presidential republic\n" +
            "Area: 640,679 km2\n" +
            "Population: 67,348,000";
            string countryPath = @"Images\Countries\france.png";

            IUnityContainer container = new UnityContainer();
            container.RegisterType<CountryModel>();

            CountryModel country = container.Resolve<CountryModel>();
            country.CountryName = countryName;
            country.CapitalName = capitalName;
            country.CountryInfo = territoryInfo;
            country.CountryPath = countryPath;

            return country;
        }
        public static ICountry CreateBulgaria()
        {
            string countryName = "Bulgaria";
            string capitalName = "Sofia";
            string territoryInfo =
            "Official languages: Bulgarian\n" +
            "Government: Unitary parliamentary republic\n" +
            "Area: 110,993.6 km2\n" +
            "Population: 7,050,034";
            string countryPath = @"Images\Countries\bulgaria.png";

            IUnityContainer container = new UnityContainer();
            container.RegisterType<CountryModel>();

            CountryModel country = container.Resolve<CountryModel>();
            country.CountryName = countryName;
            country.CapitalName = capitalName;
            country.CountryInfo = territoryInfo;
            country.CountryPath = countryPath;

            return country;
        }
        public static ICountry CreateSerbia()
        {
            string countryName = "Serbia";
            string capitalName = "Belgrade";
            string territoryInfo =
            "Official languages: Serbian\n" +
            "Government: Unitary parliamentary constitutional republic\n" +
            "Area: 88,361 km2\n" +
            "Population: 7,001,444";
            string countryPath = @"Images\Countries\serbia.png";

            IUnityContainer container = new UnityContainer();
            container.RegisterType<CountryModel>();

            CountryModel country = container.Resolve<CountryModel>();
            country.CountryName = countryName;
            country.CapitalName = capitalName;
            country.CountryInfo = territoryInfo;
            country.CountryPath = countryPath;

            return country;
        }
        public static ICountry CreateGermany()
        {
            string countryName = "Germany";
            string capitalName = "Berlin";
            string territoryInfo =
            "Official languages: German\n" +
            "Government: Federal parliamentary republic\n" +
            "Area: 357,386 km2\n" +
            "Population: 83,000,000";
            string countryPath = @"Images\Countries\germany.png";

            IUnityContainer container = new UnityContainer();
            container.RegisterType<CountryModel>();

            CountryModel country = container.Resolve<CountryModel>();
            country.CountryName = countryName;
            country.CapitalName = capitalName;
            country.CountryInfo = territoryInfo;
            country.CountryPath = countryPath;

            return country;
        }
        public static ICountry CreateBrazil()
        {
            string countryName = "Brazil";
            string capitalName = "Brasilia";
            string territoryInfo =
            "Official languages: Brazilian\n" +
            "Government: Federal presidential constitutional republic\n" +
            "Area: 8,515,767 km2\n" +
            "Population: 210,147,125";
            string countryPath = @"Images\Countries\brazil.png";

            IUnityContainer container = new UnityContainer();
            container.RegisterType<CountryModel>();

            CountryModel country = container.Resolve<CountryModel>();
            country.CountryName = countryName;
            country.CapitalName = capitalName;
            country.CountryInfo = territoryInfo;
            country.CountryPath = countryPath;

            return country;
        }
        public static ICountry CreateEmptyCountry(string countryPath = "")
        {
            string countryName = "";
            string capitalName = "";
            string territoryInfo = "";

            IUnityContainer container = new UnityContainer();
            container.RegisterType<CountryModel>();

            CountryModel country = container.Resolve<CountryModel>();
            country.CountryName = countryName;
            country.CapitalName = capitalName;
            country.CountryInfo = territoryInfo;
            country.CountryPath = countryPath;

            return country;
        }
    }
}
