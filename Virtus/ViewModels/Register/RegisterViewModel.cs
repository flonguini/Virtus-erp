namespace Virtus
{
    public class RegisterViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The current register page
        /// </summary>
        public RegisterPages RegisterContent { get; set; } = RegisterPages.Client;

        #endregion

        #region Contructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RegisterViewModel()
        {
            SubMenuCommand = new RelayParameterizedCommand(ChangeSubMenuPage);
            CreateSubMenu();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Create the sub menu buttons
        /// </summary>
        private void CreateSubMenu()
        {
            SubMenuButtons.Add(new SubMenuButton("Clientes", SubMenuCommand, "Clientes"));
            SubMenuButtons.Add(new SubMenuButton("Fornecedores", SubMenuCommand, "Fornecedores"));
            SubMenuButtons.Add(new SubMenuButton("Funcionarios", SubMenuCommand, "Funcionarios"));
            SubMenuButtons.Add(new SubMenuButton("Transportadoras", SubMenuCommand, "Transportadoras"));
        }

        /// <summary>
        /// Change the current register content
        /// </summary>
        /// <param name="menuName">The content name</param>
        protected override void ChangeSubMenuPage(object menuName)
        {
            switch (menuName)
            {
                case "Clientes":
                    // Open the register client page
                    RegisterContent = RegisterPages.Client;
                    break;
                case "Fornecedores":
                    // Open the register supplier page
                    RegisterContent = RegisterPages.Supplier;
                    break;
                case "Funcionarios":
                    // Open the register employee page
                    RegisterContent = RegisterPages.Employee;
                    break;
                case "Transportadoras":
                    // Open the register carrier page
                    RegisterContent = RegisterPages.Carrier;
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}