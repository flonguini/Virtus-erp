using PropertyChanged;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Virtus
{
    /// <summary>
    /// Base viewmodel that implements <see cref="INotifyPropertyChanged"/> interface
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        #region Public Properties

        /// <summary>
        /// Command for the menu
        /// </summary>
        public ICommand SubMenuCommand { get; set; }

        /// <summary>
        /// Collection of Sub Menu Buttons
        /// </summary>
        public ObservableCollection<SubMenuButton> SubMenuButtons { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public BaseViewModel()
        {
            SubMenuButtons = new ObservableCollection<SubMenuButton>();
        }

        #endregion

        #region Events

        /// <summary>
        /// Event that fires when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => {};

        #endregion

        #region Methods

        /// <summary>
        /// Change the page to clicked sub menu button
        /// </summary>
        /// <param name="subMenuName">Name of the page</param>
        protected virtual void ChangeSubMenuPage(object subMenuName) { }

        #endregion

    }
}
