using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtus
{
    public class Address
    {
        #region Public Properties

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
