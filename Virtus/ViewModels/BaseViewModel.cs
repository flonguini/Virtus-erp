using PropertyChanged;
using System.ComponentModel;

namespace Virtus
{
    /// <summary>
    /// Base viewmodel that implements <see cref="INotifyPropertyChanged"/> interface
    /// </summary>
    //[AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Event that fires when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => {};
    }
}
