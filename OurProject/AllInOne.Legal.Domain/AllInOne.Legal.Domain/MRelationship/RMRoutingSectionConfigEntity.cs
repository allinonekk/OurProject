//Nithin
//14-10-2010
namespace AllInOne.Legal.Domain.MRelationship
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for RMRoutingSectionConfigEntity
    /// </summary>
    [Serializable]
    public class RMRoutingSectionConfigEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        public RMRoutingSectionConfigEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public String DocCode
        {
            get;
            set;
        }

        public String ForumId
        {
            get;
            set;
        }

        public MCaseTypeEntity MCaseType
        {
            get;
            set;
        }

        public MSectionEntity MSection
        {
            get;
            set;
        }

        public MCaseTypeEntity MSubCaseType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MNOC field. </summary>
        public MNOCEntity MNOC
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MLegislationAct field. </summary>
        public MLegislationActEntity MLegislationAct
        {
            get;
            set;
        }

        public String RMRoutingSectionConfigId
        {
            get;
            set;
        }

        public String RoleCode
        {
            get;
            set;
        }


        public MProvisionEntity MProvision
        {
            get;
            set;
        }

        public string ProvisionNo
        {
            get;
            set;
        }

        public DateTime? LastSectionAssignedDate
        {
            get;
            set;
        }

        public YesNo ByPassCaseOfficerSection
        {
            get;
            set;
        }

        public string CaseTypeAdditionalAttrType
        {
            get;
            set;
        }

        public string CaseTypeAdditionalAttrValue
        {
            get;
            set;
        }

        #endregion Properties
    }
}