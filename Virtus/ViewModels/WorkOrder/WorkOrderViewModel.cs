using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Virtus
{
    public class WorkOrderViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The current budget page
        /// </summary>
        public WorkOrderPages WorkOrderContent { get; set; } = WorkOrderPages.AddWorkOrder;

        /// <summary>
        /// Command for the menu
        /// </summary>
        public ICommand MenuButton { get; set; }

        #endregion

        #region Constructos

        public WorkOrderViewModel()
        {
            SubMenuButtons = new ObservableCollection<SubMenuButton>();
            MenuButton = new RelayParameterizedCommand(ChangeSubMenuPage);
            CreateSubMenu();
        }

        #endregion

        #region Methods

        private void CreateSubMenu()
        {
            SubMenuButtons.Add(new SubMenuButton("Criar Nova OS", MenuButton, "Add"));
        }

        /// <summary>
        /// Change the current work order page
        /// </summary>
        /// <param name="menuName">The content name</param>
        protected override void ChangeSubMenuPage(object menuName)
        {
            switch (menuName)
            {
                case "Products":
                    // Open the work order client page
                    WorkOrderContent = WorkOrderPages.AddWorkOrder;
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
