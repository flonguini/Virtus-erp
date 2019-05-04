using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Virtus
{
    public class BudgetViewModel : BaseViewModel
    {
        /// <summary>
        /// The current budget page
        /// </summary>
        public BudgetPages BudgetContent { get; set; } = BudgetPages.Products;

        /// <summary>
        /// Command for the menu
        /// </summary>
        public ICommand MenuButton { get; set; }

        public BudgetViewModel()
        {
            SubMenuButtons = new ObservableCollection<SubMenuButton>();
            MenuButton = new RelayParameterizedCommand(ChangeSubMenuPage);
            CreateSubMenu();
        }

        private void CreateSubMenu()
        {
            SubMenuButtons.Add(new SubMenuButton("Orçamento de Produtos", MenuButton, "Products"));
            SubMenuButtons.Add(new SubMenuButton("Orçamento de Serviços", MenuButton, "Services"));
        }

        
        /// <summary>
        /// Change the current budget content
        /// </summary>
        /// <param name="menuName">The content name</param>
        protected override void ChangeSubMenuPage(object menuName)
        {
            switch (menuName)
            {
                case "Products":
                    // Open the budget client page
                    BudgetContent = BudgetPages.Products;
                    break;
                case "Services":
                    // Open the budget supplier page
                    BudgetContent = BudgetPages.Services;
                    break;
                default:
                    break;
            }
        }
    }
}
