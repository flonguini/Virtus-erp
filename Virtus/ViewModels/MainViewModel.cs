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
        public ApplicationPages MainContent { get; set; } = ApplicationPages.Register;

        public MainViewModel()
        {
            MainButton = new RelayParameterizedCommand(ChangeMainPage);
        }

        private void ChangeMainPage(object page)
        {
            switch (page as string)
            {
                case "Register":
                    MainContent = ApplicationPages.Register;
                    break;
                case "Budget":
                    MainContent = ApplicationPages.Budget;
                    break;
                case "Finance":
                    MainContent = ApplicationPages.Finance;
                    break;
                case "Inventory":
                    MainContent = ApplicationPages.Inventory;
                    break;
                case "Products":
                    MainContent = ApplicationPages.Products;
                    break;
                case "Reports":
                    MainContent = ApplicationPages.Reports;
                    break;
                case "Sales":
                    MainContent = ApplicationPages.Sales;
                    break;
                case "Services":
                    MainContent = ApplicationPages.Services;
                    break;
                case "WorkOrder":
                    MainContent = ApplicationPages.WorkOrder;
                    break;
                default:
                    break;
            }

        }

    }
}
