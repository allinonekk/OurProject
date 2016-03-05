namespace AllInOne.Legal.Domain.BackEndSpecific
{

    using System;

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class CAReportEntity
    {
        #region Properties


        /// <summary>
        /// Gets or sets the CA report id.
        /// </summary>
        /// <value>The CA report id.</value>
        public string CAReportId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        public string Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CreatedDate.
        /// </summary>
        /// <value>The CreatedDate.</value>
        public DateTime CreatedDate
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
        public string CreatedBy
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


        /// <summary>
        /// Gets or sets the name of the document.
        /// </summary>
        /// <value>The name of the document.</value>
        public string DocumentName
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the report file path.
        /// </summary>
        /// <value>The report file path.</value>
        public string ReportFilePath
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the remarks.
        /// </summary>
        /// <value>The remarks.</value>
        public string Remarks
        {
            get;
            set;
        }


        #endregion Properties

    }
}