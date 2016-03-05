namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.TravelPassInfoEntity'</summary>
    [Serializable]
    public class TravelPassInfoEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the DateOfExpiry field. </summary>
        public Nullable<System.DateTime> DateOfExpiry
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfIssue field. </summary>
        public Nullable<System.DateTime> DateOfIssue
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IdNumber field. </summary>
        public System.String IdNumber
        {
            get;
            set;
        }

        public String IdRemarks
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.TravelPassInfo.MCountry - Master.MCountry.TravelPassInfos (m:1)'</summary>
        public MCountryEntity MCountry
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.TravelPassInfo.MPersonIDType - Master.MPersonIDType.TravelPassInfos (m:1)'</summary>
        public MPersonIDTypeEntity MPersonIDType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TravelPassInfoId field. </summary>
        public System.String TravelPassInfoId
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
            TravelPassInfoEntity toCompareWith = obj as TravelPassInfoEntity;
            return toCompareWith == null ? false : ((this.TravelPassInfoId == toCompareWith.TravelPassInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.TravelPassInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}