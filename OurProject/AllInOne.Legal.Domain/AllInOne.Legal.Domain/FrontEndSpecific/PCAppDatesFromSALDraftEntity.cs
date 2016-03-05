namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'FrontEndSpecific.PCAppDatesFromSALDraftEntity'</summary>
    public class PCAppDatesFromSALDraftEntity : AbstractLastModified, IFrontEndSpecificEntity
    {
        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'FrontEndSpecific.PCAppDatesFromSALDraft.CaseInfo - Case.CaseInfo.PCAppDatesFromSALDrafts (m:1)'</summary>
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

        /// <summary>Gets or sets the PCAppDatesFromSALDraftId field. </summary>
        public System.String PCAppDatesFromSALDraftId
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
            PCAppDatesFromSALDraftEntity toCompareWith = obj as PCAppDatesFromSALDraftEntity;
            return toCompareWith == null ? false : ((this.PCAppDatesFromSALDraftId == toCompareWith.PCAppDatesFromSALDraftId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PCAppDatesFromSALDraftId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}