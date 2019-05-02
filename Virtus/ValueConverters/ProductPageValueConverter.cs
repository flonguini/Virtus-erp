using System;
using System.Diagnostics;
using System.Globalization;

namespace Virtus
{
    /// <summary>
    /// Converts the <see cref="RegisterPages"/> to an actual view
    /// </summary>
    public class ProductPageValueConverter : BaseValueConverter<ProductPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate view
            switch ((ProductPages)value)
            {
                case ProductPages.Add:
                    return new AddProductUserControl();
                case ProductPages.Labels:
                    return new LabelsUserControl();
                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
