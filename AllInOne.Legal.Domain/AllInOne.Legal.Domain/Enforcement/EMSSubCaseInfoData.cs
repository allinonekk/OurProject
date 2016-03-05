namespace AllInOne.Legal.Domain.Enforcement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.SubCase;

    /// <summary>
    /// Represents a standard data container object for CaseParty.
    /// </summary>
    [Serializable]
    public class EMSSubCaseInfoData
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        /// <value>The CaseInfo.</value>
        public List<CaseInfoEntity> CaseInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The DocumentInfoEntity.</value>
        public List<DocumentInfoEntity> DocumentInfos
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The EMSAccount.</value>
        public List<EMSAccountEntity> EMSAccount
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The EMSCasePartyData.</value>
        public List<EMSCasePartyData> EMSCasePartyData
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The RCaseSubmission.</value>
        public List<RCaseSubmissionEntity> RCaseSubmissions
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The SubCaseInfo.</value>
        public List<SubCaseInfoEntity> SubCaseInfo
        {
            get;
            set;
        }

        #endregion Properties
    }
}