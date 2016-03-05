namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Common.DocCaseCounterClaimDetailsEntity'</summary>
    [Serializable]
    public class DocCaseCounterClaimDetailsEntity : ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the DocCaseCounterClaimDetailID field. </summary>
        public System.String DocCaseCounterClaimDetailID
        {
            get;
            set;
        }

        public String DocCaseCounterClaimID
        {
            get;
            set;
        }

        /// <summary>DCPID</summary>
        public String DCPID
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

        /// <summary>Gets or sets the CounterClaimOrdinalNumber field. </summary>
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
            DocCaseCounterClaimDetailsEntity toCompareWith = obj as DocCaseCounterClaimDetailsEntity;
            return toCompareWith == null ? false : ((this.DocCaseCounterClaimDetailID == toCompareWith.DocCaseCounterClaimDetailID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocCaseCounterClaimDetailID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}