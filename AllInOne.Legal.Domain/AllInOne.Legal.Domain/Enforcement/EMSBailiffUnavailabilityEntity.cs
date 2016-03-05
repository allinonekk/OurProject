namespace AllInOne.Legal.Domain.Enforcement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class EMSBailiffUnavailabilityEntity
    {
        #region Properties

        /// <summary>Gets or sets the BailiffId field. </summary>
        public System.String BailiffId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSBailiffUnavailabilityId field. </summary>
        public System.String EMSBailiffUnavailabilityId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public System.String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public System.DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public System.String ObsInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UnavailableDesc field. </summary>
        public System.String UnavailableDesc
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UnavailableFromDate field. </summary>
        public System.DateTime UnavailableFromDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UnavailableFromSession field. </summary>
        public System.String UnavailableFromSession
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UnavailableToDate field. </summary>
        public System.DateTime UnavailableToDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UnavailableToSession field. </summary>
        public System.String UnavailableToSession
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
            if(obj == null)
            {
                return false;
            }
            EMSBailiffUnavailabilityEntity toCompareWith = obj as EMSBailiffUnavailabilityEntity;
            return toCompareWith == null ? false : ((this.EMSBailiffUnavailabilityId == toCompareWith.EMSBailiffUnavailabilityId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSBailiffUnavailabilityId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}