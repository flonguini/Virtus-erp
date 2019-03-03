using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtus
{
    public class RegisterClientsViewModel : BaseViewModel
    {
        #region Properties

        /// <summary>
        /// The <see cref="ClientModel"/> that it is been register
        /// </summary>
        public ClientModel Client { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RegisterClientsViewModel()
        {
            // Initialize the client property
            Client = new ClientModel();
        }

        #endregion
    }
}
