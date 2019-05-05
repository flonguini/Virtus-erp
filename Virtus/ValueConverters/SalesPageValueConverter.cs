using System;
using System.Diagnostics;
using System.Globalization;

namespace Virtus
{
    /// <summary>
    /// Converts the <see cref="SalesPages"/> to an actual view
    /// </summary>
    public class SalesPageValueConverter : BaseValueConverter<SalesPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate view
            switch ((SalesPages)value)
            {
                case SalesPages.CounterSales:
                    return new CounterSalesUserControl();
                case SalesPages.Products:
                    return new ProductsSalesUserControl();
                case SalesPages.Returned:
                    return new ReturnedSalesUserControl();
                case SalesPages.Services:
                    return new ServicesSalesUserControl();
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
