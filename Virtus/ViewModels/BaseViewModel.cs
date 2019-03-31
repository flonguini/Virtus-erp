using PropertyChanged;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Virtus
{
    /// <summary>
    /// Base viewmodel that implements <see cref="INotifyPropertyChanged"/> interface
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Event that fires when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => {};

        //protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
