using System.Windows.Input;

namespace Virtus
{
    /// <summary>
    /// Represents a submenu button
    /// </summary>
    public class SubMenuButton
    {
        #region Public Properties

        /// <summary>
        /// The content of this button
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// The command to this button
        /// </summary>
        public ICommand Command { get; set; }

        /// <summary>
        /// The parameter to this button
        /// </summary>
        public string Parameter { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initialize a new instance of this class
        /// </summary>
        /// <param name="content">The content o the button</param>
        /// <param name="command">The command associated</param>
        public SubMenuButton(string content, ICommand command, string parameter)
        {
            Content = content;
            Command = command;
            Parameter = parameter;
        }

        #endregion

    }
}
