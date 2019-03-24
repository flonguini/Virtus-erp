using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Virtus
{
    public class RegisterClientsViewModel : BaseViewModel
    {
        #region Properties

        /// <summary>
        /// The <see cref="Client"/> that it is been register
        /// </summary>
        public Client Client { get; set; }

        /// <summary>
        /// List of <see cref="Client"/> that populates the datagrid
        /// </summary>
        public ObservableCollection<Client> Clients { get; set; }

        /// <summary>
        /// The current register page
        /// </summary>
        public RegisterPage RegisterContent { get; set; } = RegisterPage.Client;

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

        public BitmapImage Image { get; set; } = new BitmapImage(new Uri(@"/Virtus;component/Resources/DefaultUser2.png", UriKind.RelativeOrAbsolute));

        public void SearchProfilePicure()
        {
            OpenFileDialog dialogBox = new OpenFileDialog();
            dialogBox.ShowDialog();
            var filename = dialogBox.FileName;
            if (!string.IsNullOrEmpty(filename))
            {
                Client.Photo = new BitmapImage(new Uri(filename));
                Image = new BitmapImage(new Uri(filename));
            }
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
