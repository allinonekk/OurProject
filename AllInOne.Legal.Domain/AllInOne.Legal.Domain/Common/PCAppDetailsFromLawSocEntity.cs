namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCase;

    /// <summary>Class which represents the entity 'Common.PCAppDetailsFromSALEntity'</summary>
    public class PCAppDetailsFromLawSocEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the AnnualSubPaidStatus field. </summary>
        public System.String AnnualSubPaidStatus
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.PCAppDetailsFromSAL.CaseInfo - Case.CaseInfo.PCAppDetailsFromSALs (m:1)'</summary>
        //public  CaseInfoEntity CaseInfo
        //{
        //    get;
        //    set;
        //}
        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public System.String CaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CompFundStatus field. </summary>
        public System.String CompFundStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the InsurnCvrgDate field. </summary>
        public Nullable<System.DateTime> InsurnCvrgDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the InsurnCvrgEndDate field. </summary>
        public DateTime? InsurnCvrgEndDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the InsurnCvrgStartDate field. </summary>
        public DateTime? InsurnCvrgStartDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsExternalAgencyUserApproved field. </summary>
        public System.String IsExternalAgencyUserApproved
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsSavedinPCINFO field. </summary>
        public YesNo IsSavedinPCINFO
        {
            get;
            set;
        }

        /// <summary>Gets or sets the KeyFromLawSoc field. </summary>
        public System.String KeyFromLawSoc
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MembershipCategory field. </summary>
        public System.String MembershipCategory
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PCAppDetailsFromLawSocId field. </summary>
        public System.String PCAppDetailsFromLawSocId
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.PCAppDetailsFromSAL.SubCaseInfo - SubCase.SubCaseInfo.PCAppDetailsFromSALs (m:1)'</summary>
        //public  SubCaseInfoEntity SubCaseInfo
        //{
        //    get;
        //    set;
        //}
        /// <summary>Gets or sets the SubCaseInfoId field. </summary>
        public System.String SubCaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the VoteInfo field. </summary>
        public System.String VoteInfo
        {
            get;
            set;
        }

        public decimal? SubscriptionFee { get; set; }

        public decimal? CompensationFee { get; set; }

        public string PCInfo
        {
            get;
            set;
        }

        public decimal? PCCaseYear
        {
            get;
            set;
        }

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
            PCAppDetailsFromLawSocEntity toCompareWith = obj as PCAppDetailsFromLawSocEntity;
            return toCompareWith == null ? false : ((this.PCAppDetailsFromLawSocId == toCompareWith.PCAppDetailsFromLawSocId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PCAppDetailsFromLawSocId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}