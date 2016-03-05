namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    [Serializable]
    public class UserDesignationEntity : AbstractLastModified, IBackEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the EndDate field.
        /// </summary>
        /// <value>The EndDate</value>
        public DateTime? EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MDesignation field.
        /// </summary>
        /// <value>The MDesignation</value>
        public MDesignationEntity MDesignation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the StartDate field.
        /// </summary>
        /// <value>The StartDate</value>
        public DateTime StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UserId field.
        /// </summary>
        /// <value>The UserId</value>
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

            UserDesignationEntity toCompareWith = obj as UserDesignationEntity;
            return toCompareWith == null ? false : ((this.UserId == toCompareWith.UserId) && (this.MDesignation == toCompareWith.MDesignation));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.UserId.GetHashCode();
            toReturn ^= this.MDesignation.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}