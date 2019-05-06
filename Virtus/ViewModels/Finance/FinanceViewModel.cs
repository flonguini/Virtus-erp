using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtus
{
    public class FinanceViewModel : BaseViewModel
    {
        #region Public Properties

        public FinancePages FinanceContent { get; set; } = FinancePages.AccountsPayable;

        #endregion

        #region Constructors

        public FinanceViewModel()
        {
            SubMenuCommand = new RelayParameterizedCommand(ChangeSubMenuPage);
            CreateSubMenu();
        }

        #endregion

        #region Methods

        private void CreateSubMenu()
        {
            SubMenuButtons.Add(new SubMenuButton("Contas a Pagar", SubMenuCommand, "AccountsPayable"));
            SubMenuButtons.Add(new SubMenuButton("Contas a Receber", SubMenuCommand, "AccountsReceivable"));
            SubMenuButtons.Add(new SubMenuButton("Fluxo de Caixa", SubMenuCommand, "CashFlow"));
            SubMenuButtons.Add(new SubMenuButton("Boletos", SubMenuCommand, "Boletos"));
            SubMenuButtons.Add(new SubMenuButton("Caixas", SubMenuCommand, "Cashier"));
            SubMenuButtons.Add(new SubMenuButton("Contas Bancárias", SubMenuCommand, "BankAccount"));
            SubMenuButtons.Add(new SubMenuButton("Formas de Pagamento", SubMenuCommand, "Payment"));
        }

        protected override void ChangeSubMenuPage(object subMenuName)
        {
            switch (subMenuName)
            {
                case "AccountsPayable":
                    FinanceContent = FinancePages.AccountsPayable;
                    break;
                case "AccountsReceivable":
                    FinanceContent = FinancePages.AccountsReceivable;
                    break;
                case "CashFlow":
                    FinanceContent = FinancePages.CashFlow;
                    break;
                case "Boletos":
                    FinanceContent = FinancePages.Boletos;
                    break;
                case "Cashier":
                    FinanceContent = FinancePages.Cashier;
                    break;
                case "BankAccount":
                    FinanceContent = FinancePages.BankAccount;
                    break;
                case "Payment":
                    FinanceContent = FinancePages.Payment;
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
