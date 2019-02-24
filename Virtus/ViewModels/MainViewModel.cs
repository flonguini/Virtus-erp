using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtus
{
    /// <summary>
    /// The main page view model
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage MainContent { get; set; } = ApplicationPage.Register;

    }
}
