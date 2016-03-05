namespace AllInOne.Legal.Domain.Enforcement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.SubCase;

    [Serializable]
    public class EMSCasePartyData
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        /// <value>The CasePartyEntity.</value>
        public List<CasePartyEntity> CaseParty
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The CasePartyAddressEntity.</value>
        public List<CasePartyAddressEntity> CasePartyAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The CasePartyAICAddressEntity.</value>
        public List<CasePartyAICAddressEntity> CasePartyAICAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The CasePartyAICAliasEntity.</value>
        public List<CasePartyAICAliasEntity> CasePartyAICAlias
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The CasePartyAICDetailsEntity.</value>
        public List<CasePartyAICDetailsEntity> CasePartyAICDetails
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The CasePartyAliasEntity.</value>
        public List<CasePartyAliasEntity> CasePartyAlias
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>The SubCasePartyEntity.</value>
        public List<SubCasePartyEntity> SubCaseParty
        {
            get;
            set;
        }

        #endregion Properties
    }
}