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
            // Initialize the client property
            Client = new Client();

            SearchPicture = new RelayCommand(SearchProfilePicure);

            SaveClient = new RelayCommand(SaveNewClient);

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

        public void SearchProfilePicure()
        {
            MessageBox.Show("oi");
        }

        public void SaveNewClient()
        {
            MessageBox.Show("Olá");
            Clients.Add(Client);
        }

        #endregion
    }
}
