using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllInOne.Legal.Entities.BackEnd
{
    public class PatientInfo
    {

        private System.String _obsInd;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual System.String LastModifiedBy
        {
            get { return _lastModifiedBy; }
            set { _lastModifiedBy = value; }
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual System.DateTime LastModifiedDate
        {
            get { return _lastModifiedDate; }
            set { _lastModifiedDate = value; }
        }

        String _patientId;
        /// <summary>Gets or sets the PatientId field. </summary>
        public virtual System.String PatientId
        {
            get { return _patientId; }
            set { _patientId = value; }
        }

        String _userName;
        /// <summary>Gets or sets the UserName field. </summary>
        public virtual System.String UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        String _emailId;
        /// <summary>Gets or sets the EmailId field. </summary>
        public virtual System.String EmailId
        {
            get { return _emailId; }
            set { _emailId = value; }
        }
    }
}
