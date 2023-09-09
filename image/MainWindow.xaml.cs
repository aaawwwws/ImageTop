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
        public BitmapImage _image { get; set; }
        private static int Run = 0;

        public MainWindow()
        {
            InitializeComponent();
            this.Main();
            this.KeyDown += new KeyEventHandler(F12);
         }

        //メインメソッド()
        private void Main()
        {
            if (Run < 1)
            {
                ImageSelect IS = new ImageSelect(this);
                IS.ImageSet();
                _image = IS.ImageUri;
                Run++;
            }
            else
            {
                this.ImageShow(_image);
            }
        }

        public void ImageShow(BitmapImage Image)
        {
            this.Image.StretchDirection = StretchDirection.DownOnly;
            this.Image.Source = Image;
        }

        //F12を押したら実行
        private void F12(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F12)
            {
                Window1 BorderLess = new Window1();
                BorderLess.Left = this.Left;
                BorderLess.Top = this.Top;
                BorderLess.Topmost = true;
                BorderLess.Show();
                BorderLess.ImageShow(_image);
                this.Close();
            }
        }
    }
}
