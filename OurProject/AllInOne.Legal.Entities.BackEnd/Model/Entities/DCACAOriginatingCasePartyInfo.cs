namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

       /// <summary>
    /// Represents a standard domain entity for DocComments.
    /// It inherits from <see cref="AbstractDocId"/>
    /// </summary>
    [Serializable]
    public class DCACAOriginatingCasePartyInfo : ICaseSpecific
    {
        #region Properties

        public virtual string DCACAOriginatingCasePartyInfoId
        { get; set; }
        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>The action.</value>
        public virtual string DCPID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the comment id.
        /// </summary>
        /// <value>The comment id.</value>
        public virtual MPartyType MPartyType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>The comments.</value>
        public virtual string ObsInd
        {
            get;
            set;
        }

        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        public virtual string SubmissionGroupId
        {
            get;
            set;
        }

        public virtual decimal? OrdinalNumber
        {
            get;
            set;
        }
        #endregion Properties
    }
}