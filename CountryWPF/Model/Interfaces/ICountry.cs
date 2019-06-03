using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CountryWPF.Model.Interfaces
{
    public interface  ICountry
    {
        string CountryName { get; set; }
        string CapitalName { get; set; }
        string CountryInfo { get; set; }
        string CountryPath { get; set; }
        ImageSource CountryFlag { get; set; }
        bool IsDeleted { get; set; }
    }
}
