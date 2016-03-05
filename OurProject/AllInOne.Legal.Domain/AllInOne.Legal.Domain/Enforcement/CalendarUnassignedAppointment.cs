namespace AllInOne.Legal.Domain.Enforcement
{
    using System;

    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Enforcement.EMSAccount'</summary>
    [Serializable]
    public class CalendarUnassignedAppointment : ICustomizedEntity
    {
        #region Properties

        /// <summary>Gets or sets the BailiffId field. </summary>
        public String AppointmentBailiffId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BailiffId field. </summary>
        public String AppointmentBailiffUserName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ApptDateTime field. </summary>
        public DateTime? ApptDateTime
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public String CaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseNo field. </summary>
        public String CaseNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSAccountId field. </summary>
        public String EMSAccountId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSAppointmentId field. </summary>
        public String EMSAppointmentId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSType field. </summary>
        public EMSType EMSType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExecAddress field. </summary>
        public String ExecAddress
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSAppointment.MEMSApptType - Master.MEMSApptType.EMSAppointments (m:1)'</summary>
        public MEMSApptTypeEntity MEMSApptType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OutOfcHrStatus field. </summary>
        public OutOfOfficeStatus OutOfcHrStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SequenceNo field. </summary>
        public int SequenceNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubCaseInfoId field. </summary>
        public String SubCaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseNo field. </summary>
        public String SubCaseNo
        {
            get;
            set;
        }

        #endregion Properties
    }
}