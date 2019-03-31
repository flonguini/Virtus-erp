using System;
using System.Windows.Media.Imaging;

namespace Virtus
{
    /// <summary>
    /// The client register model
    /// </summary>
    public class Client : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The client e-mail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Type of client person or company
        /// </summary>
        public TypeOfPerson Type { get; set; }

        /// <summary>
        /// Situation active or inactive
        /// </summary>
        public Situation Situation { get; set; }

        /// <summary>
        /// The name of the client
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The CPF or CNPJ
        /// </summary>
        public string CpfOrCnpj { get; set; }

        /// <summary>
        /// Date of Birth
        /// </summary>
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Date of register
        /// </summary>
        public DateTime DateOfRegister { get; set; } = DateTime.Now;

        /// <summary>
        /// The client site
        /// </summary>
        public string Site { get; set; }

        /// <summary>
        /// The client phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The client cell phone
        /// </summary>
        public string CellPhone { get; set; }

        /// <summary>
        /// Profile picture
        /// </summary>
        public BitmapImage Photo { get; set; }

        /// <summary>
        /// The client Address
        /// </summary>
        public Address Address { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public Client()
        {
            Address = new Address();
            Photo = new BitmapImage(new Uri(@"/Virtus;component/Resources/DefaultUser2.png", UriKind.RelativeOrAbsolute));
        }

        #endregion
    }
}
