namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCase;

    /// <summary>Class which represents the entity 'Common.PCAppDatesFromSALEntity'</summary>
    public class PCAppDatesFromSALEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'Common.PCAppDatesFromSAL.CaseInfo - Case.CaseInfo.PCAppDatesFromSALs (m:1)'</summary>
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

        /// <summary>Gets or sets the CommOfOathsAppDate field. </summary>
        public Nullable<System.DateTime> CommOfOathsAppDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CommOfOathsAppExpDate field. </summary>
        public Nullable<System.DateTime> CommOfOathsAppExpDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HasAnyDiffWithApplData field. </summary>
        public System.String HasAnyDiffWithApplData
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsBackEndUserApproved field. </summary>
        public System.String IsBackEndUserApproved
        {
            get;
            set;
        }

        /// <summary>Gets or sets the KeyFromSAL field. </summary>
        public System.String KeyFromSAL
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NPAppDate field. </summary>
        public Nullable<System.DateTime> NPAppDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NPAppExpDate field. </summary>
        public Nullable<System.DateTime> NPAppExpDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PCAppDatesFromSALId field. </summary>
        public System.String PCAppDatesFromSALId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SALfeePaidStatus field. </summary>
        public System.String SALfeePaidStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SCAppDate field. </summary>
        public Nullable<System.DateTime> SCAppDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SCAppExpDate field. </summary>
        public Nullable<System.DateTime> SCAppExpDate
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Common.PCAppDatesFromSAL.SubCaseInfo - SubCase.SubCaseInfo.PCAppDatesFromSALs (m:1)'</summary>
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

        public decimal? SALFee { get; set; }

        public string SALMembership { get; set; }

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
            PCAppDatesFromSALEntity toCompareWith = obj as PCAppDatesFromSALEntity;
            return toCompareWith == null ? false : ((this.PCAppDatesFromSALId == toCompareWith.PCAppDatesFromSALId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PCAppDatesFromSALId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}