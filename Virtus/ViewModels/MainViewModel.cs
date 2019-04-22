using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Virtus
{
    /// <summary>
    /// The main page view model
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// The main page buttons command
        /// </summary>
        public ICommand MainButton { get; set; }

        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage MainContent { get; set; } = ApplicationPage.Register;

        public MainViewModel()
        {
            MainButton = new RelayParameterizedCommand(ChangeMainPage);
        }

        private void ChangeMainPage(object page)
        {
            switch (page as string)
            {
                case "Register":
                    MainContent = ApplicationPage.Register;
                    break;
                case "Budget":
                    MainContent = ApplicationPage.Budget;
                    break;
                case "Finance":
                    MainContent = ApplicationPage.Finance;
                    break;
                case "Inventory":
                    MainContent = ApplicationPage.Inventory;
                    break;
                case "Products":
                    MainContent = ApplicationPage.Products;
                    break;
                case "Reports":
                    MainContent = ApplicationPage.Reports;
                    break;
                case "Sales":
                    MainContent = ApplicationPage.Sales;
                    break;
                case "Services":
                    MainContent = ApplicationPage.Services;
                    break;
                case "WorkOrder":
                    MainContent = ApplicationPage.WorkOrder;
                    break;
                default:
                    break;
            }

        }

    }
}
