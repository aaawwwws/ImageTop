using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace image
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static ImageSelect ImageFile = new ImageSelect();
        private string ImageFileName;

        public MainWindow()
        {
            InitializeComponent();
            this.ImageSet();
            this.Topmost = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { }

        private void ImageSet()
        {
            ImageSelect ImageFIles = new ImageSelect();
            if (this.ImageFileName == null)
            {
                ImageFileName = ImageFIles.FileSelect();
                BitmapImage ImageUri = new BitmapImage(new Uri(ImageFileName));
                Image.StretchDirection = StretchDirection.DownOnly;
                Image.Source = ImageUri;
            }
            else
            {
                return;
            }
        }
    }
}
