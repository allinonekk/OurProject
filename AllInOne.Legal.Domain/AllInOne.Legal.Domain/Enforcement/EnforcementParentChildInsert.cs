namespace AllInOne.Legal.Domain.Enforcement
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Domain.SubCase;

    [Serializable]
    public class CaseRegirestrationParentChildInsert : EnforcementParentChildInsert
    {
        #region Properties

        //Non-Enforcement but Common entities
        public List<CaseInfoEntity> listCaseInfo
        {
            get;
            set;
        }

        public List<CasePartyEntity> listCaseParty
        {
            get;
            set;
        }

        public List<CasePartyAddressEntity> listCasePartyAddress
        {
            get;
            set;
        }

        public List<DocumentInfoEntity> listDocumentInfo
        {
            get;
            set;
        }

        public List<RCaseSubmissionEntity> listRCaseSubmission
        {
            get;
            set;
        }

        public List<SubCaseInfoEntity> listSubCaseInfo
        {
            get;
            set;
        }

        public List<SubCasePartyEntity> listSubCaseParty
        {
            get;
            set;
        }

        #endregion Properties
    }

    /// <summary>Class which represents the entity 'Enforcement.EMSAccount'</summary>
    [Serializable]
    public class EnforcementParentChildInsert
    {
        #region Properties

        //Enforcement Related entities
        public List<IEnforcementEntity> listChild
        {
            get; set;
        }

        public List<IEnforcementEntity> listGrandChild
        {
            get; set;
        }

        public List<IEnforcementEntity> listParent
        {
            get; set;
        }

        #endregion Properties
    }
}