using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace image
{
    internal class ImageSelect
    {
        public static OpenFileDialog SelectDialog = new OpenFileDialog();
        public string FileSelect()
        {
            try
            {
                SelectDialog.Filter = "イメージファイル(*.png)|*.png|すべてのファイル(*.*)|*.*";
                SelectDialog.ShowDialog();
                var FileName = SelectDialog.FileName;
                MessageBox.Show(FileName);
                return FileName;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "画像が選択されていません";
            }
        } }
    
}
