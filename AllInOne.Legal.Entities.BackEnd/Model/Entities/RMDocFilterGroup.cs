namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

    /// <summary>
    /// Represents a standard domain entity for RMDocFilterGroup.
    /// </summary>
    [Serializable]
    public class RMDocFilterGroup : IMaster
    {
        #region Properties

        /// <summary>Gets or sets the DocCode field. </summary>
        public virtual string DocCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FilterGroupId field. </summary>
        public virtual string FilterGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public virtual string ObsInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            RMDocFilterGroup toCompareWith = obj as RMDocFilterGroup;
            return toCompareWith == null ? false : ((this.FilterGroupId == toCompareWith.FilterGroupId)
                && (this.DocCode == toCompareWith.DocCode));

        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FilterGroupId.GetHashCode();
            toReturn ^= this.DocCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}