using Avalonia;
using Avalonia.Data.Converters;
using Avalonia.Media.Imaging;
using System;
using System.Globalization;

namespace lively.Helpers.MVVM
{
    /// <summary>
    /// Converts a string path to a bitmap asset.
    /// </summary>
    public class BitmapAssetValueConverter : IValueConverter
    {
        public static BitmapAssetValueConverter Instance = new BitmapAssetValueConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //return new Bitmap((string)value);
            try
            {
                if (value is string fileName)
                {
                    var bi = new Bitmap(fileName);
                    //return bi.CreateScaledBitmap(new PixelSize(208, 117), Avalonia.Visuals.Media.Imaging.BitmapInterpolationMode.HighQuality);
                    return bi;
                }
            }
            catch { }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
