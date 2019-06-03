using CountryWPF.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CountryWPF.Model
{
    public class CountryModel : ICountry, INotifyPropertyChanged
    {
        private string countryName;
        private string capitalName;
        private string countryInfo;
        private ImageModel countryFlag;
        private string countryPath;
        private bool isDeleted;

        public event PropertyChangedEventHandler PropertyChanged;
        public string CountryName
        {
            get
            {
                return countryName;
            }
            set
            {
                if (countryName != value)
                {
                    countryName = value;
                    RaisePropertyChanged("CountryName");

                }
            }
        }
        public string CapitalName
        {
            get
            {
                return this.capitalName;
            }
            set
            {
                if (capitalName != value)
                {
                    capitalName = value;
                    RaisePropertyChanged("CapitalName");
                }
            }
        }
        public string CountryInfo
        {
            get
            {
                return this.countryInfo;
            }
            set
            {
                if (countryInfo != value)
                {
                    countryInfo = value;
                    RaisePropertyChanged("CountryInfo");
                }
            }
        }
        public string CountryPath
        {
            get
            {
                return this.countryPath;
            }
            set
            {
                try
                {
                    if (value == "")
                    {
                        this.countryPath = value;
                        RaisePropertyChanged("CountryPath");
                    }
                    else
                    {
                        this.countryPath = value;
                        this.countryFlag.SetImageData(File.ReadAllBytes(value));
                    }
                }
                catch (Exception) { }
            }
        }
        public ImageSource CountryFlag
        {
            get
            {
                return this.countryFlag.ImageSource;
            }
            set
            {
                if (countryFlag.ImageSource != value)
                {
                    countryFlag.ImageSource = value;
                    RaisePropertyChanged("CountryFlag");
                }
            }
        }
        public bool IsDeleted
        {
            get
            {
                return this.isDeleted;
            }
            set
            {
                this.isDeleted = value;
            }
        }

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public CountryModel()
        {
            this.countryFlag = new ImageModel();
            this.isDeleted = false;
        }
    }
}
