using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace image
{
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window
    {
        private BitmapImage _image;

        public Window1()
        {
            this.AllowsTransparency = true;
            this.WindowStyle = WindowStyle.None;
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(F12);
        }

        public void ImageShow(BitmapImage Image)
        {
            this._image = Image;
            this.ImageBL.StretchDirection = StretchDirection.DownOnly;
            this.ImageBL.Source = Image;
        }

        private void F12(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F12)
            {
                MainWindow MW = new MainWindow();
                MW.Left = this.Left;
                MW.Top = this.Top;
                MW._image = this._image;
                MW.Show();
                MW.ImageShow(this._image);
                this.Close();
            }
        }
    }
}
