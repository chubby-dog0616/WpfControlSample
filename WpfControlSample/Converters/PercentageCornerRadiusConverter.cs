using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfControlSample.Converters
{
    internal class PercentageCornerRadiusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not double val) { return new CornerRadius(0); }

            var percentage = parameter switch
            {
                double p => p,
                int p => p,
                string s when double.TryParse(s, out var parsed) => parsed,
                _ => 100
            };
            var clamped = Math.Clamp(percentage, 0, 100);
            return new CornerRadius(val * (clamped/ 100.0));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotSupportedException();
    }
}
