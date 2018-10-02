using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace TreeViewWPF
{
    /// <summary>
    /// Конвертер  путей для выбора изображений папок и файлов
    /// </summary>
    [ValueConversion(typeof(string),typeof(BitmapImage))]
    public  class HeaderToImageConverter : IValueConverter
    {
        public static HeaderToImageConverter Instance = new HeaderToImageConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //получаем полный путь
            var path = (string)value;
            //если путь нулевой то игнорируем
            if(path==null)
            {
                return null;
            }
            else
            {
                var name = MainWindow.GetFileFolderName(path);
                var image = "Images/file.png";
                //если имя хедера , равно диску то мы выбираем изображение с диском
                if(string.IsNullOrEmpty(name))
                {
                    image = "Images/drive.png";
                }
                else if (new FileInfo(path).Attributes.HasFlag(FileAttributes.Directory))//если это папка
                {
                    image = "Images/folder-closed.png";
                }
                return new BitmapImage(new Uri($"pack://application:,,,/{image}"));
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
