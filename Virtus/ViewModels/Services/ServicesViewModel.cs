namespace Virtus
{
    public class ServicesViewModel : BaseViewModel
    {
        #region Public Properties

        public ServicesPages ServicesContent { get; set; } = ServicesPages.Add;

        #endregion

        #region Constructors

        public ServicesViewModel()
        {
            SubMenuButtons.Add(new SubMenuButton("Adicionar Serviço", SubMenuCommand, "AddService"));
        }

        #endregion

    }
}
