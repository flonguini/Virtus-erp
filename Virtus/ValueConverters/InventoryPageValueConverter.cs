using System;
using System.Diagnostics;
using System.Globalization;

namespace Virtus
{
    /// <summary>
    /// Converts the <see cref="InventoryPages"/> to an actual view
    /// </summary>
    public class InventoryPageValueConverter : BaseValueConverter<InventoryPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate view
            switch ((InventoryPages)value)
            {
                case InventoryPages.Adjusts:
                    return new InventoryAdjustsUserControl();
                case InventoryPages.Prices:
                    return new InventoryPricesUserControl();
                case InventoryPages.Purchases:
                    return new InventoryPurchasesUserControl();
                case InventoryPages.StockMoviments:
                    return new InventoryStockMovimentsUserControl();
                case InventoryPages.Transfers:
                    return new InventoryTransfersUserControl();
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
