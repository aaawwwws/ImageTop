﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace image
{
    internal class Settings
    {
        public Settings() { }

        public static void Window_setting(dynamic NewWindow, dynamic OldWindow)
        {
            // 引数の型を明示的に指定
            NewWindow.Left = OldWindow.Left;
            NewWindow.Top = OldWindow.Top;
            NewWindow.Topmost = true;
            NewWindow.ImageShow(OldWindow._image);
            NewWindow.Show();
            OldWindow.Close();
        }
    }
}