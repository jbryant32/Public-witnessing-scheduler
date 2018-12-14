using PWSSchduler.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace PWSSchduler.Converters
{
    public class ObjectToAlertItem : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value as AlertPageItem;
        }
        //The ConvertBack method is called when data moves from the target to the source in TwoWay or OneWayToSource
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value as object;
        }
    }
}
