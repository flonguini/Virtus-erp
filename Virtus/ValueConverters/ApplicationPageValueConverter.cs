using System;
using System.Diagnostics;
using System.Globalization;

namespace Virtus
{
    /// <summary>
    /// Converts the <see cref="ApplicationPages"/> to an actual view
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate view
            switch ((ApplicationPages)value)
            {
                case ApplicationPages.Register:
                    return new RegisterUserControl();
                case ApplicationPages.Products:
                    return new ProductsUserControl();
                case ApplicationPages.Budget:
                    return new BudgetUserControl();
                case ApplicationPages.Finance:
                    return new FinanceUserControl();
                case ApplicationPages.Inventory:
                    return new InventoryUserControl();
                case ApplicationPages.Reports:
                    return new ReportsUserControl();
                case ApplicationPages.Sales:
                    return new SalesUserControl();
                case ApplicationPages.Services:
                    return new ServicesUserControl();
                case ApplicationPages.WorkOrder:
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
