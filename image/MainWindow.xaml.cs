﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
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
        private static bool Run = true;

        public MainWindow()
        {
            InitializeComponent();
            this.Main();
            this.KeyDown += new KeyEventHandler(F12);
        }

        //メインメソッド()
        private void Main()
        {
            if (MainWindow.Run)
            {
                ImageSelect IS = new ImageSelect(this);
                IS.ImageSet();
                _image = IS.ImageUri;
                MainWindow.Run = false;
            }
            else
            {
                return;
            }
        }

        public void ImageShow(BitmapImage Image)
        {
            this._image = Image;
            this.Image.StretchDirection = StretchDirection.DownOnly;
            this.Image.Source = _image;
        }

        //F12を押したら実行
        private void F12(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F12:
                    Settings.Window_setting(new Window1(), this);
                    break;

                case Key.F11:
                    break;
            }
        }
    }
}
