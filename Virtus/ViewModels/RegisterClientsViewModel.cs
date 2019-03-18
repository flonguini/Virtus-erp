using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Virtus
{
    public class RegisterClientsViewModel : BaseViewModel
    {
        #region Properties

        /// <summary>
        /// The <see cref="Virtus.Client"/> that it is been register
        /// </summary>
        public Client Client { get; set; }

        /// <summary>
        /// List of <see cref="Virtus.Client"/> that populates the datagrid
        /// </summary>
        public ObservableCollection<Client> Clients { get; set; }

        /// <summary>
        /// The current register page
        /// </summary>
        public RegisterPage RegisterContent { get; set; } = RegisterPage.Employee;

        #endregion

        #region Commands

        /// <summary>
        /// Command to search the profile picture
        /// </summary>
        public ICommand SearchPicture { get; set; }

        /// <summary>
        /// Command to save the client
        /// </summary>
        public ICommand SaveClient { get; set; }

        /// <summary>
        /// Command for the menu
        /// </summary>
        public ICommand MenuButton { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RegisterClientsViewModel()
        {
            // Initialize the client property
            Client = new Client();

            SearchPicture = new RelayCommand(SearchProfilePicure);

            SaveClient = new RelayCommand(SaveNewClient);

            MenuButton = new RelayParameterizedCommand(ChangeMenuPage);

            Clients = new ObservableCollection<Client>
            {
                new Client
                {
                    Name = "Fernando",
                    Type = TypeOfPerson.Fisica,
                    Situation = Situation.Ativo,
                    PhoneNumber = "3565-5495",
                    CellPhone = "11 9 6199-2735",
                    Email = "flonguini@outlook.com",
                    DateOfRegister = DateTime.Now
                },

                new Client
                {
                    Name = "Rafaela",
                    Type = TypeOfPerson.Juridica,
                    Situation = Situation.Ativo,
                    PhoneNumber = "3565-5495",
                    CellPhone = "11 9 6199-2735",
                    Email = "rafaela@outlook.com",
                    DateOfRegister = DateTime.Now
                },

                new Client
                {
                    Name = "Roberta",
                    Type = TypeOfPerson.Fisica,
                    Situation = Situation.Ativo,
                    PhoneNumber = "3565-5495",
                    CellPhone = "11 9 6199-2735",
                    Email = "Roberta@outlook.com",
                    DateOfRegister = DateTime.Now
                }
            };
        }

        #endregion

        #region Methods

        public void ChangeMenuPage(object name)
        {
            switch (name)
            {
                case "Clientes":
                    RegisterContent = RegisterPage.Client;
                    break;
                case "Fornecedores":
                    RegisterContent = RegisterPage.Supplier;
                    break;
                case "Funcionarios":
                    RegisterContent = RegisterPage.Employee;
                    break;
                case "Transportadoras":
                    RegisterContent = RegisterPage.Carrier;
                    break;
                default:
                    break;
            }
        }

        public void SearchProfilePicure()
        {
            MessageBox.Show("oi");
        }

        public void SaveNewClient()
        {
            var c = new Client
            {
                Email = Client.Email,
                Type = Client.Type,
                Situation = Client.Situation,
                Name = Client.Name,
                CpfOrCnpj = Client.CpfOrCnpj,
                DateOfBirth = Client.DateOfBirth,
                DateOfRegister = DateTime.Now,
                Site = Client.Site,
                PhoneNumber = Client.PhoneNumber,
                CellPhone = Client.PhoneNumber,
                Address = new Address
                {
                    ZipCode = Client.Address.ZipCode,
                    Street = Client.Address.Street,
                    Number = Client.Address.Number,
                    Complement = Client.Address.Complement,
                    Neighborhood = Client.Address.Neighborhood,
                    State = Client.Address.State,
                    City = Client.Address.City
                }
            };

            Clients.Add(c);
        }

        #endregion
    }
}
