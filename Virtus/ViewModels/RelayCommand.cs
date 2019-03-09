using System;
using System.Windows.Input;

namespace Virtus
{
    /// <summary>
    /// Basic command that runs an Action
    /// </summary>
    public class RelayCommand : ICommand
    {

        #region Private members

        private readonly Action _action;

        #endregion

        #region Public Events

        /// <summary>
        /// The event thats fired when the <see cref="CanExecute(object)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #endregion

        #region Constructor

        public RelayCommand(Action action)
        {
            _action = action;
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// A relay can always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Executes the command action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _action();
        }

        #endregion
    }
}
