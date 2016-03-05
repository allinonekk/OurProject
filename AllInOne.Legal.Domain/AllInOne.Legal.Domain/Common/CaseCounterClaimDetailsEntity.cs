namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.CaseCounterClaimDetailsEntity'</summary>
    [Serializable]
    public class CaseCounterClaimDetailsEntity : ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the CaseCounterClaimDetailID field. </summary>
        public System.String CaseCounterClaimDetailID
        {
            get;
            set;
        }

        public String CaseCounterClaimID
        {
            get;
            set;
        }

        /// <summary>CasePartyID</summary>
        public String CasePartyID
        {
            get;
            set;
        }

        /// <summary>CounterClaimOrdinalNumber</summary>
        public System.Int64 CounterClaimOrdinalNumber
        {
            get;
            set;
        }
        /// <summary>CounterClaimPartyTypeCode</summary>
        public String CounterClaimPartyTypeCode
        {
            get;
            set;
        }

        /// <summary>CounterClaimPartyNo</summary>
        public String CounterClaimPartyNo
        {
            get;
            set;
        }

        /// <summary>CounterClaimPartyStatusCode</summary>
        public String CounterClaimPartyStatusCode
        {
            get;
            set;
        }

        /// <summary>CounterClaimPartyStatusDate</summary>
        public System.DateTime? CounterClaimPartyStatusDate
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
        public YesNo ObsInd
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
            CaseCounterClaimDetailsEntity toCompareWith = obj as CaseCounterClaimDetailsEntity;
            return toCompareWith == null ? false : ((this.CaseCounterClaimDetailID == toCompareWith.CaseCounterClaimDetailID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseCounterClaimDetailID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}