using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtus
{
    public class InventoryViewModel : BaseViewModel
    {

        #region Public Properties

        public InventoryPages InventoryContent { get; set; } = InventoryPages.Transfers;

        #endregion

        #region Constructors

        public InventoryViewModel()
        {
            SubMenuCommand = new RelayParameterizedCommand(ChangeSubMenuPage);
            CreateSubMenu();
        }

        #endregion

        #region Methods

        private void CreateSubMenu()
        {
            SubMenuButtons.Add(new SubMenuButton("Movimentações", SubMenuCommand, "StockMoviments"));
            SubMenuButtons.Add(new SubMenuButton("Ajustes", SubMenuCommand, "Adjusts"));
            SubMenuButtons.Add(new SubMenuButton("Transferências", SubMenuCommand, "Transfers"));
            SubMenuButtons.Add(new SubMenuButton("Cotações", SubMenuCommand, "Prices"));
            SubMenuButtons.Add(new SubMenuButton("Compras", SubMenuCommand, "Purchases"));
        }

        protected override void ChangeSubMenuPage(object subMenuName)
        {
            switch (subMenuName)
            {
                case "StockMoviments":
                    InventoryContent = InventoryPages.StockMoviments;
                    break;
                case "Adjusts":
                    InventoryContent = InventoryPages.Adjusts;
                    break;
                case "Transfers":
                    InventoryContent = InventoryPages.Transfers;
                    break;
                case "Prices":
                    InventoryContent = InventoryPages.Prices;
                    break;
                case "Purchases":
                    InventoryContent = InventoryPages.Purchases;
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
