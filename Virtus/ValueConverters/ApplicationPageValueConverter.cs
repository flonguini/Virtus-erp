using System;
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
                case ApplicationPage.Products:
                    return new ProducsUserControl();
                case ApplicationPage.Budget:
                    return new BudgetUserControl();
                case ApplicationPage.Finance:
                    return new FinanceUserControl();
                case ApplicationPage.Inventory:
                    return new InventoryUserControl();
                case ApplicationPage.Reports:
                    return new ReportsUserControl();
                case ApplicationPage.Sales:
                    return new SalesUserControl();
                case ApplicationPage.Services:
                    return new ServicesUserControl();
                case ApplicationPage.WorkOrder:
                    return new WorkOrderUserControl();
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
