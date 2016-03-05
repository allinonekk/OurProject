namespace AllInOne.Legal.Domain.BackEndSpecific
{

    using System;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class ReportConfigTaskInfoEntity : IBackEndSpecificEntity
    {
        #region Properties


        /// <summary>
        /// Gets or sets the CA report id.
        /// </summary>
        /// <value>The CA report id.</value>
        public string ReportConfigTaskInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        public string ReportConfigInfoId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the LastModifiedBy.
        /// </summary>
        /// <value>The LastModifiedBy.</value>
        public string LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>The created by.</value>
        public string Status
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the LastModifiedDate.
        /// </summary>
        /// <value>The LastModifiedDate.</value>
        public DateTime LastModifiedDate
        {
            get;
            set;
        }

        public string GroupId
        {
            get;
            set;
        }

        #endregion Properties

    }
}