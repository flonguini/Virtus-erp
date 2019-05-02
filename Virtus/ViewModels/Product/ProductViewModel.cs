using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Virtus
{
    public class ProductViewModel : BaseViewModel
    {
        private ObservableCollection<SubMenuButton> _subMenuButtons;

        public ObservableCollection<SubMenuButton> SubMenuButtons
        {
            get { return _subMenuButtons; }
            set { _subMenuButtons = value; }
        }


        /// <summary>
        /// The current register page
        /// </summary>
        public ProductPages ProductContent { get; set; } = ProductPages.Add;


        /// <summary>
        /// Command for the menu
        /// </summary>
        public ICommand MenuButton { get; set; }

        public ProductViewModel()
        {
            SubMenuButtons = new ObservableCollection<SubMenuButton>();
            MenuButton = new RelayParameterizedCommand(ChangeSubMenuPage);
            CreateSubMenu();
        }

        private void CreateSubMenu()
        {
            _subMenuButtons.Add(new SubMenuButton("Adicionar Produto", MenuButton, "Add"));
            _subMenuButtons.Add(new SubMenuButton("Gerar Etiquetas", MenuButton, "Labels"));
        }

        /// <summary>
        /// Change the current register content
        /// </summary>
        /// <param name="menuName">The content name</param>
        public void ChangeSubMenuPage(object menuName)
        {
            switch (menuName)
            {
                case "Add":
                    // Open the register client page
                    ProductContent = ProductPages.Add;
                    break;
                case "Labels":
                    // Open the register supplier page
                    ProductContent = ProductPages.Labels;
                    break;
                default:
                    break;
            }
        }
    }
}
