using System.Windows.Controls;

namespace Virtus
{
    /// <summary>
    /// Interaction logic for RegisterUserControl.xaml
    /// </summary>
    public partial class RegisterUserControl : UserControl
    {
        public RegisterUserControl()
        {
            InitializeComponent();

            DataContext = new RegisterClientsViewModel();
        }
    }
}
