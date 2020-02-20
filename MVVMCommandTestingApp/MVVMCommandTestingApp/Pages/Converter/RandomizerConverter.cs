using System;
using System.Globalization;
using Xamarin.Forms;

namespace MVVMCommandTestingApp.Pages.Converter
{
    class RandomizerConverter : IValueConverter
    {
        Random rnd = new Random();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value + rnd.Next(0, 360);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
