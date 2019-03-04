using System;

namespace Virtus
{
    /// <summary>
    /// The client register model
    /// </summary>
    public class ClientModel
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
        /// The client zip code
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// The street from client
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Number from client address
        /// </summary>
        public int? Number { get; set; }

        /// <summary>
        /// Other informations from client address
        /// </summary>
        public string Complement { get; set; }

        /// <summary>
        /// The naughborhood from client
        /// </summary>
        public string Neighborhood { get; set; }

        /// <summary>
        /// State from client
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// City from client
        /// </summary>
        public string City { get; set; }

        #endregion
    }
}
