namespace AllInOne.Legal.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    using AllInOne.Legal.Entities.BackEnd;

    /// <summary>
    ///	Generated by MyGeneration using the NHibernate Object Mapping template
    /// </summary>
    public class Users : IBackEndSpecific
    {
        #region Fields

        private Nullable<DateTime> m_assigneddate;
        private System.String m_casefileinspectionind;
        private System.String m_courtid;
        private System.String m_displayname;
        private System.String m_emailaddress;
        private Nullable<DateTime> m_enddate;
        private System.String m_faxareacode;
        private System.String m_faxcountrycode;
        private System.String m_faxnumber;
        private System.String m_groupcode;
        private System.String m_initials;
        private System.String m_lastmodifiedby;
        private DateTime m_lastmodifieddate;
        private System.String m_lawnetindicator;
        private System.String m_localdownloadlocation;
        private System.String m_obsind;
        private Nullable<System.Int32> m_senioritylevel;
        private byte[] m_signature;
        private System.String m_signaturepath;
        private Nullable<DateTime> m_startdate;
        private System.String m_telareacode;
        private System.String m_telcountrycode;
        private System.String m_telnumber;
        private System.String m_userid;
        private System.String m_username;

        #endregion Fields

        #region Constructors

        public Users()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public virtual Nullable<System.DateTime> AssignedDate
        {
            get { return m_assigneddate; }
            set
            {
                m_assigneddate = value;
            }
        }

        public virtual System.String CaseFileInspectionInd
        {
            get { return m_casefileinspectionind; }
            set
            {
                m_casefileinspectionind = value;
            }
        }

        public virtual System.String CourtID
        {
            get { return m_courtid; }
            set
            {
                m_courtid = value;
            }
        }

        public virtual System.String DisplayName
        {
            get { return m_displayname; }
            set
            {
                m_displayname = value;
            }
        }

        public virtual System.String eMailAddress
        {
            get { return m_emailaddress; }
            set
            {
                m_emailaddress = value;
            }
        }

        public virtual Nullable<System.DateTime> EndDate
        {
            get { return m_enddate; }
            set
            {
                m_enddate = value;
            }
        }

        public virtual System.String FaxAreaCode
        {
            get { return m_faxareacode; }
            set
            {
                m_faxareacode = value;
            }
        }

        public virtual System.String FaxCountryCode
        {
            get { return m_faxcountrycode; }
            set
            {
                m_faxcountrycode = value;
            }
        }

        public virtual System.String FaxNumber
        {
            get { return m_faxnumber; }
            set
            {
                m_faxnumber = value;
            }
        }

        public virtual System.String GroupCode
        {
            get { return m_groupcode; }
            set
            {
                m_groupcode = value;
            }
        }

        public virtual System.String Initials
        {
            get { return m_initials; }
            set
            {
                m_initials = value;
            }
        }

        public virtual System.String LastModifiedBy
        {
            get { return m_lastmodifiedby; }
            set
            {
                m_lastmodifiedby = value;
            }
        }

        public virtual DateTime LastModifiedDate
        {
            get { return m_lastmodifieddate; }
            set
            {
                m_lastmodifieddate = value;
            }
        }

        public virtual System.String LawnetIndicator
        {
            get { return m_lawnetindicator; }
            set
            {
                m_lawnetindicator = value;
            }
        }

        public virtual System.String LocalDownloadLocation
        {
            get { return m_localdownloadlocation; }
            set
            {
                m_localdownloadlocation = value;
            }
        }

        public virtual System.String ObsInd
        {
            get { return m_obsind; }
            set
            {
                m_obsind = value;
            }
        }

        public virtual Nullable<System.Int32> SeniorityLevel
        {
            get { return m_senioritylevel; }
            set
            {
                m_senioritylevel = value;
            }
        }

        public virtual byte[] Signature
        {
            get { return m_signature; }
            set
            {
                m_signature = value;
            }
        }

        public virtual System.String SignaturePath
        {
            get { return m_signaturepath; }
            set
            {
                m_signaturepath = value;
            }
        }

        public virtual Nullable<System.DateTime> StartDate
        {
            get { return m_startdate; }
            set
            {
                m_startdate = value;
            }
        }

        public virtual System.String TelAreaCode
        {
            get { return m_telareacode; }
            set
            {
                m_telareacode = value;
            }
        }

        public virtual System.String TelCountryCode
        {
            get { return m_telcountrycode; }
            set
            {
                m_telcountrycode = value;
            }
        }

        public virtual System.String TelNumber
        {
            get { return m_telnumber; }
            set
            {
                m_telnumber = value;
            }
        }

        public virtual System.String UserId
        {
            get { return m_userid; }
            set
            {
                if( value == null )
                    throw new ArgumentOutOfRangeException("Null value not allowed for UserId", value, "null");

                m_userid = value;
            }
        }

        public virtual System.String UserName
        {
            get { return m_username; }
            set
            {
                m_username = value;
            }
        }


        /// <summary>
        /// Gets or sets the login page identifier.
        /// </summary>
        /// <value>
        /// The login page identifier.
        /// </value>
        public virtual System.String LoginPageId { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Users toCompareWith = obj as Users;
            return toCompareWith == null ? false : ((this.UserId == toCompareWith.UserId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.UserId.GetHashCode();
            return toReturn;
        }

        public override string ToString()
        {
            return 		"UserId=" + UserId + "--" +
            "CourtID=" + CourtID + "--" +
            "UserName=" + UserName + "--" +
            "DisplayName=" + DisplayName + "--" +
            "SeniorityLevel=" + SeniorityLevel + "--" +
            "eMailAddress=" + eMailAddress + "--" +
            "ObsInd=" + ObsInd + "--" +
            "EndDate=" + EndDate + "--" +
            "LocalDownloadLocation=" + LocalDownloadLocation + "--" +
            "Signature=" + Signature + "--" +
            "GroupCode=" + GroupCode + "--" +
            "LastModifiedBy=" + LastModifiedBy + "--" +
            "LastModifiedDate=" + LastModifiedDate + "--" +
            "StartDate=" + StartDate + "--" +
            "Initials=" + Initials + "--" +
            "AssignedDate=" + AssignedDate + "--" +
            "CaseFileInspectionInd=" + CaseFileInspectionInd + "--" +
            "LawnetIndicator=" + LawnetIndicator + "--" +
            "TelCountryCode=" + TelCountryCode + "--" +
            "TelAreaCode=" + TelAreaCode + "--" +
            "TelNumber=" + TelNumber + "--" +
            "FaxCountryCode=" + FaxCountryCode + "--" +
            "FaxAreaCode=" + FaxAreaCode + "--" +
            "FaxNumber=" + FaxNumber + "--" +
            "SignaturePath=" + SignaturePath + "--" +
            "";
        }

        #endregion Methods
    }
}