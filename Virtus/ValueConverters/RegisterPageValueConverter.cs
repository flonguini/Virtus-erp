using System;
using System.Diagnostics;
using System.Globalization;

namespace Virtus
{
    /// <summary>
    /// Converts the <see cref="RegisterPage"/> to an actual view
    /// </summary>
    public class RegisterPageValueConverter : BaseValueConverter<RegisterPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate view
            switch ((RegisterPage)value)
            {
                case RegisterPage.Client:
                    return new RegisterClientsUserControl();
                case RegisterPage.Supplier:
                    return new RegisterSupplierUserControl();
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
