using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace image
{
    internal class ImageSelect
    {
        private string ImageFileName;
        private string FIlename;
        public BitmapImage ImageUri { get; private set; }
        //委譲先のインスタンスを取得
        public MainWindow MW;
        public ImageSelect(MainWindow MW)
        {
            this.MW = MW;
        }

        //ファイル選択
        public string FileSelect()
        {
            OpenFileDialog SelectDialog = new OpenFileDialog();
            try
            {
                SelectDialog.Filter = "イメージファイル(*.bmp;*.gif;*.png;*.jpeg;*.jpg)|*.bmp;*.gif;*.png;*.jpeg;*.jpg|すべてのファイル(*.*)|*.*";
                SelectDialog.ShowDialog();
                string FileName = SelectDialog.FileName;
                return FileName;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return e.Message;
            }

        }

        //画像ファイルが用意されているか確認
        public void ImageSet()
        {

            if (ImageFileName == null)
            {
                FileCheck();
            }
            else
            {
                return;
            }
        }

        //ファイル自体が選択されているか確認
        public void FileCheck()
        {
            while (true)
            {
                try
                {
                    ImageFileName = this.FileSelect();
                    this.ImageUri = new BitmapImage(new Uri(ImageFileName));
                    this.MW._image = this.ImageUri;
                    this.MW.Image.StretchDirection = StretchDirection.DownOnly;
                    this.MW.Image.Source = this.ImageUri;
                    break;
                }
                catch (NotSupportedException e)
                {
                    MessageBox.Show("サポートされていない形式のファイルが選択されました");
                }
                catch (UriFormatException e)
                {
                    this.MW.Close();
                    break;
                }
            }
        }
    }
}
