using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace MVVMCommandTestingApp.Pages.Converter
{
    public class AmplifierConverter : IValueConverter
    {
        private const double DEGREES_MULT = 360;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value * DEGREES_MULT;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value / DEGREES_MULT;
        }
    }
}
