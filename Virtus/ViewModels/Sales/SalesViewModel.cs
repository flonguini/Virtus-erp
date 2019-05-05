namespace Virtus
{
    public class SalesViewModel : BaseViewModel
    {
        #region Public Properties

        public SalesPages SalesContent { get; set; } = SalesPages.Products;

        #endregion

        #region Constructors

        public SalesViewModel()
        {
            SubMenuCommand = new RelayParameterizedCommand(ChangeSubMenuPage);
            CreateSubMenu();
        }

        #endregion

        #region Methods

        private void CreateSubMenu()
        {
            SubMenuButtons.Add(new SubMenuButton("Produtos", SubMenuCommand, "Products"));
            SubMenuButtons.Add(new SubMenuButton("Balcão", SubMenuCommand, "CounterSales"));
            SubMenuButtons.Add(new SubMenuButton("Serviços", SubMenuCommand, "Services"));
            SubMenuButtons.Add(new SubMenuButton("Devoluções", SubMenuCommand, "Returned"));
        }

        protected override void ChangeSubMenuPage(object subMenuName)
        {
            switch (subMenuName)
            {
                case "Products":
                    SalesContent = SalesPages.Products;
                    break;
                case "CounterSales":
                    SalesContent = SalesPages.CounterSales;
                    break;
                case "Services":
                    SalesContent = SalesPages.Services;
                    break;
                case "Returned":
                    SalesContent = SalesPages.Returned;
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
