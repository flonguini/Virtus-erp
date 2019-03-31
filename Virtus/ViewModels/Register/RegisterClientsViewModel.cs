using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Client> ClientsList { get; set; }

        public BitmapImage Image { get; set; } = new BitmapImage(new Uri(@"/Virtus;component/Resources/DefaultUser2.png", UriKind.RelativeOrAbsolute));

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

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RegisterClientsViewModel()
        {
            Client = new Client();

            ClientsList = new ObservableCollection<Client>();

            SearchPicture = new RelayCommand(SearchProfilePicure);

            SaveClient = new RelayCommand(SaveNewClient);
        }

        #endregion

        #region Methods

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

            // TODO: Save client to the database
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

            ClientsList.Add(c);

            Client = new Client();
        }

        #endregion
    }
}
