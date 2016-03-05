namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MBusinessJobLegalInfo'</summary>
    public class MBusinessJobLegalInfoEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the BusinessGroup.
        /// </summary>
        /// <value>The BusinessGroup.</value>
        public String BusinessGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BusinessJobLegalInfoId field.
        /// </summary>
        /// <value>The Business Job Legal Info id.</value>
        public String BusinessJobLegalInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BusinessName.
        /// </summary>
        /// <value>The BusinessName.</value>
        public String BusinessName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseTypeCode.
        /// </summary>
        /// <value>The CaseTypeCode.</value>
        public String CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FrequencyType.
        /// </summary>
        /// <value>The FrequencyType.</value>
        public FrequencyType FrequencyType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocCode.
        /// </summary>
        /// <value>The DocCode.</value>
        public MDocCodeEntity MDocCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ForumId.
        /// </summary>
        /// <value>The ForumId.</value>
        public MForumTypeEntity MForumType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MonitoringTypeCode.
        /// </summary>
        /// <value>The MonitoringTypeCode.</value>
        public MMonitoringTypeEntity MMonitoringType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseTypeCode.
        /// </summary>
        /// <value>The SubCaseTypeCode.</value>
        public String SubCaseTypeCode
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
            MBusinessJobLegalInfoEntity toCompareWith = obj as MBusinessJobLegalInfoEntity;
            return toCompareWith == null ? false : ((this.BusinessJobLegalInfoId == toCompareWith.BusinessJobLegalInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BusinessJobLegalInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}