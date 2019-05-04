using System;
using System.Diagnostics;
using System.Globalization;

namespace Virtus
{
    /// <summary>
    /// Converts the <see cref="BudgetPages"/> to an actual view
    /// </summary>
    public class BudgetPageValueConverter : BaseValueConverter<BudgetPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate view
            switch ((BudgetPages)value)
            {
                case BudgetPages.Products:
                    return new AddProductsBudgetUserControl();
                case BudgetPages.Services:
                    return new AddServicesBudgetUserControl();
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
