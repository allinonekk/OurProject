namespace AllInOne.Legal.Domain.Audit
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Audit.AuditModuleVisitEntity'</summary>
    public class AuditModuleVisitEntity : AbstractLastModified, IAuditEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the type of the action.
        /// </summary>
        /// <value>The type of the action.</value>
        public String ActionType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the alert description.
        /// </summary>
        /// <value>The alert description.</value>
        public String AlertDescription
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the alert user id.
        /// </summary>
        /// <value>The alert user id.</value>
        public String AlertUserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the audit module visit id.
        /// </summary>
        /// <value>The audit module visit id.</value>
        public String AuditModuleVisitId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the created date time.
        /// </summary>
        /// <value>The created date time.</value>
        public DateTime CreatedDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public String Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the module.
        /// </summary>
        /// <value>The module.</value>
        public String Module
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        /// <value>The user id.</value>
        public String UserId
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            AuditModuleVisitEntity toCompareWith = obj as AuditModuleVisitEntity;
            return toCompareWith == null ? false : ((this.AuditModuleVisitId == toCompareWith.AuditModuleVisitId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AuditModuleVisitId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}