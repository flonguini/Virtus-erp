﻿using System;
using System.Diagnostics;
using System.Globalization;

namespace Virtus
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual view
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate view
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Register:
                    return new RegisterUserControl();
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
