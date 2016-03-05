namespace AllInOne.Legal.Domain.Common
{
    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'FrontEndSpecific.DocAppProcessByExAgencyEntity'</summary>
    public class DocAppProcessByExAgencyEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        ///// <summary>Represents the navigator which is mapped onto the association 'FrontEndSpecific.DocAppProcessByExAgency.CaseInfo - Case.CaseInfo.DocAppProcessByExAgencies (m:1)'</summary>
        //public CaseInfoEntity CaseInfo
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

        /// <summary>Gets or sets the Date field. </summary>
        public System.DateTime Date
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DecisionReason field. </summary>
        public System.String DecisionReason
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DocAppByExAgId field. </summary>
        public System.String DocAppByExAgId
        {
            get;
            set;
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'FrontEndSpecific.DocAppProcessByExAgency.DocumentInfo - Document.DocumentInfo.DocAppProcessByExAgencies (m:1)'</summary>
        //public DocumentInfoEntity DocumentInfo
        //{
        //    get;
        //    set;
        //}
        /// <summary>Gets or sets the DocId field. </summary>
        public System.String DocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsD1Saved field. </summary>
        public YesNo IsD1Saved
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsD2Saved field. </summary>
        public YesNo IsD2Saved
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsD3Saved field. </summary>
        public YesNo IsD3Saved
        {
            get;
            set;
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'FrontEndSpecific.DocAppProcessByExAgency.LawFirm - Common.LawFirm.DocAppProcessByExAgencies (m:1)'</summary>
        //public LawFirmEntity LawFirmDAPBEALFIDToDisplay
        //{
        //    get;
        //    set;
        //}
        /// <summary>Gets or sets the LFIDToDisplay field. </summary>
        public System.String LFIDToDisplay
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'FrontEndSpecific.DocAppProcessByExAgency.MDocStatu - Master.MDocStatus.DocAppProcessByExAgencies (m:1)'</summary>
        public MDocStatusEntity MDocStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MessageType field. </summary>
        public System.String MessageType
        {
            get;
            set;
        }

        ///// <summary>Gets or sets the LFID field. </summary>
        //public System.String LFID
        //{
        //    get;
        //    set;
        //}
        /// <summary>Represents the navigator which is mapped onto the association 'FrontEndSpecific.DocAppProcessByExAgency.MExternalAgency - Master.MExternalAgency.DocAppProcessByExAgencies (m:1)'</summary>
        public MExternalAgencyEntity MExternalAgency
        {
            get;
            set;
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'FrontEndSpecific.DocAppProcessByExAgency.SubCaseInfo - SubCase.SubCaseInfo.DocAppProcessByExAgencies (m:1)'</summary>
        //public SubCaseInfoEntity SubCaseInfo
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

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public System.String SubmissionGroupId
        {
            get;
            set;
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'FrontEndSpecific.DocAppProcessByExAgency.LawFirmUser - FrontEndSpecific.LawFirmUser.DocAppProcessByExAgencies (m:1)'</summary>
        //public LawFirmUserEntity LawFirmUser
        //{
        //    get;
        //    set;
        //}
        /// <summary>Gets or sets the UserId field. </summary>
        public System.String UserId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the VerifiedApplicantDetail field. </summary>
        public YesNo VerifiedApplicantDetail
        {
            get;
            set;
        }

        /// <summary>Gets or sets the VerifiedAppointmentDetail field. </summary>
        public YesNo VerifiedAppointmentDetail
        {
            get;
            set;
        }

        public YesNo IsAccRptLawSoc
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
            DocAppProcessByExAgencyEntity toCompareWith = obj as DocAppProcessByExAgencyEntity;
            return toCompareWith == null ? false : ((this.DocAppByExAgId == toCompareWith.DocAppByExAgId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocAppByExAgId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}