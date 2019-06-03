using System.ComponentModel;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CountryWPF.Model
{
    public class ImageModel : INotifyPropertyChanged
    {
        private ImageSource imageSource;
        public event PropertyChangedEventHandler PropertyChanged;

        public ImageSource ImageSource
        {
            get { return imageSource; }
            set
            {
                imageSource = value;
                OnPropertyChanged("ImageSource");
            }
        }

        public void SetImageData(byte[] data)
        {
            var source = new BitmapImage();
            source.BeginInit();
            source.StreamSource = new MemoryStream(data);
            source.EndInit();

            ImageSource = source;
        }
        protected void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
