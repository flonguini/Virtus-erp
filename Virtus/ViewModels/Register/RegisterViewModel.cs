﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Virtus
{
    public class RegisterViewModel : BaseViewModel
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
        public RegisterPages RegisterContent { get; set; } = RegisterPages.Client;


        /// <summary>
        /// Command for the menu
        /// </summary>
        public ICommand MenuButton { get; set; }

        public RegisterViewModel()
        {
            SubMenuButtons = new ObservableCollection<SubMenuButton>();
            MenuButton = new RelayParameterizedCommand(ChangeSubMenuPage);
            CreateSubMenu();
        }

        private void CreateSubMenu()
        {
            _subMenuButtons.Add(new SubMenuButton("Clientes", MenuButton, "Clientes"));
            _subMenuButtons.Add(new SubMenuButton("Fornecedores", MenuButton, "Fornecedores"));
            _subMenuButtons.Add(new SubMenuButton("Funcionarios", MenuButton, "Funcionarios"));
            _subMenuButtons.Add(new SubMenuButton("Transportadoras", MenuButton, "Transportadoras"));
        }

        /// <summary>
        /// Change the current register content
        /// </summary>
        /// <param name="menuName">The content name</param>
        public void ChangeSubMenuPage(object menuName)
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
    }
}
