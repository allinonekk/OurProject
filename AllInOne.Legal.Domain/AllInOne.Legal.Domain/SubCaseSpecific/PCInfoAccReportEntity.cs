namespace AllInOne.Legal.Domain.SubCaseSpecific
{
    using System;

    public class PCInfoAccReportEntity
    {
        #region Properties 
        
        /// <summary>Gets or sets the PCInfoAccReport field. </summary>
        public String PCInfoAccReportId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PCInfoId field. </summary>
        public String PCInfoId
        {
            get;
            set;
        }

        public String FileName
        {
            get;
            set;
        }

        public Nullable<DateTime> FromDate
        {
            get;
            set;
        }

        public Nullable<DateTime> ToDate
        {
            get;
            set;
        }

        public String NRIC
        {
            get;
            set;
        }
        
        #endregion
    }
}