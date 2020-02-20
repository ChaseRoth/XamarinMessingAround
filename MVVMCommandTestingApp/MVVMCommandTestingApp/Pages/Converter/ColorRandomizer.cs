using System;
using System.Globalization;
using Xamarin.Forms;

namespace MVVMCommandTestingApp.Pages.Converter
{
    public class ColorRandomizer : IValueConverter
    {
        Random rnd = new Random();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
