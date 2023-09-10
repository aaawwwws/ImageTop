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
    public partial class Window1 : Window
    {
        public BitmapImage _image { get; set; }

        public Window1()
        {
            this.AllowsTransparency = true;
            this.WindowStyle = WindowStyle.None;
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(KeyInput);
        }

        public void ImageShow(BitmapImage Image)
        {
            this._image = Image;
            this.ImageBL.StretchDirection = StretchDirection.DownOnly;
            this.ImageBL.Source = _image;
        }

        private void KeyInput(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F12:
                    Settings.Window_setting(new MainWindow(), this);
                    break;

                case Key.F11:
                    this.IsHitTestVisible = false;
                    break;
            }
        }
    }
}
