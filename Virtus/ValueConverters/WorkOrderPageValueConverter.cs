using System;
using System.Diagnostics;
using System.Globalization;

namespace Virtus
{
    /// <summary>
    /// Converts the <see cref="WorkOrderPages"/> to an actual view
    /// </summary>
    public class WorkOrderPageValueConverter : BaseValueConverter<WorkOrderPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate view
            switch ((WorkOrderPages)value)
            {
                case WorkOrderPages.AddWorkOrder:
                    return new AddWorkOrderUserControl();
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
