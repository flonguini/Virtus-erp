﻿using System;
using System.Diagnostics;
using System.Globalization;

namespace Virtus
{
    /// <summary>
    /// Converts the <see cref="RegisterPages"/> to an actual view
    /// </summary>
    public class RegisterPageValueConverter : BaseValueConverter<RegisterPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate view
            switch ((RegisterPages)value)
            {
                case RegisterPages.Client:
                    return new RegisterClientsUserControl();
                case RegisterPages.Supplier:
                    return new RegisterSupplierUserControl();
                case RegisterPages.Employee:
                    return new RegisterEmployeeUserControl();
                case RegisterPages.Carrier:
                    return new RegisterCarrierUserControl();
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
