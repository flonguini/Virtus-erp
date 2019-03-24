using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Virtus
{
    public class RegisterViewModel : BaseViewModel
    {
        /// <summary>
        /// The current register page
        /// </summary>
        public RegisterPage RegisterContent { get; set; } = RegisterPage.Client;


        /// <summary>
        /// Command for the menu
        /// </summary>
        public ICommand MenuButton { get; set; }

        public RegisterViewModel()
        {
            MenuButton = new RelayParameterizedCommand(ChangeMenuPage);
        }

        /// <summary>
        /// Change the current register content
        /// </summary>
        /// <param name="menuName">The content name</param>
        public void ChangeMenuPage(object menuName)
        {
            switch (menuName)
            {
                case "Clientes":
                    // Open the register client page
                    RegisterContent = RegisterPage.Client;
                    break;
                case "Fornecedores":
                    // Open the register supplier page
                    RegisterContent = RegisterPage.Supplier;
                    break;
                case "Funcionarios":
                    // Open the register employee page
                    RegisterContent = RegisterPage.Employee;
                    break;
                case "Transportadoras":
                    // Open the register carrier page
                    RegisterContent = RegisterPage.Carrier;
                    break;
                default:
                    break;
            }
        }
    }
}
