using System;
using System.Collections.Generic;

namespace DatabaseApi
{
    public interface IDbInformation
    {
        /// <summary>
        /// Gets the name of the dll.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the display name of the dll, typically used in UI contexts.
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// Gets a brief description of the dll.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the path to the executable file for the dll.
        /// </summary>
        string ExecutablePath { get; }

        /// <summary>
        /// Gets the version of the dll file.
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Gets a dictionary of configuration settings for the dll.
        /// </summary>
        /// <remarks>
        /// The dictionary keys represent configuration setting names, and the values represent the corresponding settings.
        /// </remarks>
        Dictionary<string, string> Configurations { get; }
    }
}