// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
namespace Xenko.Core.Presentation.Services
{
    /// <summary>
    /// An interface representing a modal folder selection dialog.
    /// </summary>
    public interface IFolderOpenModalDialog : IModalDialog
    {
        /// <summary>
        /// Gets or sets the initial directory of the folder dialog.
        /// </summary>
        string InitialDirectory { get; set; }

        /// <summary>
        /// Gets the directory selected by the user.
        /// </summary>
        string Directory { get; }
    }
}
