namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'FrontEndSpecific.PCAppDetailsFromLawSocDraftEntity'</summary>
    public class PCAppDetailsFromLawSocDraftEntity : AbstractLastModified, IFrontEndSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the AnnualSubPaidStatus field. </summary>
        public System.String AnnualSubPaidStatus
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'FrontEndSpecific.PCAppDetailsFromSALDraft.CaseInfo - Case.CaseInfo.PCAppDetailsFromSALDrafts (m:1)'</summary>
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

        /// <summary>Gets or sets the InsurnanceCoverageDate field. </summary>
        public Nullable<System.DateTime> InsurnanceCoverageDate
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

        /// <summary>Gets or sets the PCAppDetailsFromLawSocDraftId field. </summary>
        public System.String PCAppDetailsFromLawSocDraftId
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
            PCAppDetailsFromLawSocDraftEntity toCompareWith = obj as PCAppDetailsFromLawSocDraftEntity;
            return toCompareWith == null ? false : ((this.PCAppDetailsFromLawSocDraftId == toCompareWith.PCAppDetailsFromLawSocDraftId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PCAppDetailsFromLawSocDraftId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}