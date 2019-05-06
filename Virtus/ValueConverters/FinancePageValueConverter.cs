using System;
using System.Diagnostics;
using System.Globalization;

namespace Virtus
{
    /// <summary>
    /// Converts the <see cref="FinancePages"/> to an actual view
    /// </summary>
    public class FinancePageValueConverter : BaseValueConverter<FinancePageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate view
            switch ((FinancePages)value)
            {
                case FinancePages.AccountsPayable:
                    return new FinanceAccountsPayableUserControl();
                case FinancePages.AccountsReceivable:
                    return new FinanceAccountsReceivableUserControl();
                case FinancePages.BankAccount:
                    return new FinanceBankAccountUserControl();
                case FinancePages.Boletos:
                    return new FinanceBoletosUserControl();
                case FinancePages.CashFlow:
                    return new FinanceCashFlowUserControl();
                case FinancePages.Cashier:
                    return new FinanceCashierUserControl();
                case FinancePages.Payment:
                    return new FinancePaymentUserControl();
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
