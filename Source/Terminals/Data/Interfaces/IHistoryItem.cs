using System;
using System.Xml.Serialization;

namespace Terminals.Data
{
    /// <summary>
    /// Represents one favorite touch when trying connect to its server.
    /// Stored is time stamp and user who accessed it. Useful for access audits.
    /// </summary>
    internal interface IHistoryItem
    {
        /// <summary>
        /// Gets or sets access time stamp of time when the favorite connection was initialized.
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Gets the user name with domain prefix in form of DOMAIN\USERNAME
        /// </summary>
        [XmlIgnore]
        string UserName { get; }

        /// <summary>
        /// Gets or sets associated favorite. This is only a navigation property
        /// </summary>
        [XmlIgnore]
        IFavorite Favorite { get; set; }

        /// <summary>
        /// Assigns current user security id to it, if the user account is domain.
        /// For local user account this value isn't set to preserver file persistence space,
        /// because all history items than have the same value.
        /// </summary>
        void AssignCurentUser();
    }
}