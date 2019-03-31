using System;
using System.Diagnostics;
using System.Globalization;

namespace Virtus
{
    /// <summary>
    /// Converts the <see cref="TypeOfPerson"/> to an string
    /// </summary>
    public class NamesValueConverter : BaseValueConverter<NamesValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate view
            switch ((TypeOfPerson)value)
            {
                case TypeOfPerson.Fisica:
                    return "Nome";
                case TypeOfPerson.Juridica:
                    return "Nome Fantasia";
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
