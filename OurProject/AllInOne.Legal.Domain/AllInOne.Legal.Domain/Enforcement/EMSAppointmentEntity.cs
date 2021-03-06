﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Domain.Enforcement
{
    using System;

    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Enforcement.EMSAppointment'</summary>
    [Serializable]
    public class EMSAppointmentEntity : IEnforcementEntity
    {
        #region Properties

        /// <summary>Gets or sets the AppointmentGroup field. </summary>
        public String AppointmentGroup
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ApptDateTime field. </summary>
        public Nullable<System.DateTime> ApptDateTime
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ApptReasonDesc field. </summary>
        public System.String ApptReasonDesc
        {
            get;
            set;
        }

        ///// <summary>Gets or sets the AttendanceFee field. </summary>
        //public Nullable<Decimal> AttendanceFee
        //{
        //    get;
        //    set;
        //}

        /// <summary>Gets or sets the BailiffId field. </summary>
        public System.String BailiffId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DepositAmt field. </summary>
        public Nullable<System.Decimal> DepositAmt
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DocId field. </summary>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSAccountId field. </summary>
        public System.String EMSAccountId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EMSAppointmentId field. </summary>
        public System.String EMSAppointmentId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExecAddr1 field. </summary>
        public System.String ExecAddr1
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExecAddr2 field. </summary>
        public System.String ExecAddr2
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExecAddr3 field. </summary>
        public System.String ExecAddr3
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExecAddr4 field. </summary>
        public System.String ExecAddr4
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExecAddrBlkNo field. </summary>
        public System.String ExecAddrBlkNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExecAddrBuildingName field. </summary>
        public System.String ExecAddrBuildingName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExecAddress field. </summary>
        public System.String ExecAddress
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExecAddrFloorNo field. </summary>
        public System.String ExecAddrFloorNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExecAddrFormatInd field. </summary>
        public AddressFormatType ExecAddrFormatInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExecAddrPostalCode field. </summary>
        public System.String ExecAddrPostalCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExecAddrStreetName field. </summary>
        public System.String ExecAddrStreetName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExecAddrUnitNo field. </summary>
        public System.String ExecAddrUnitNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsHidden field. </summary>
        public YesNo IsHidden
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public System.String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public System.DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSAppointment.MEMSApptOutcome - Master.MEMSApptOutcome.EMSAppointments (m:1)'</summary>
        public MEMSApptOutcomeEntity MEMSApptOutcome
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSAppointment.MEMSApptReason - Master.MEMSApptReason.EMSAppointments (m:1)'</summary>
        public MEMSApptReasonEntity MEMSApptReason
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

        /// <summary>Gets or sets the MEMSAuctioneer field. </summary>
        public MEMSAuctioneerEntity MEMSAuctioneer
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public YesNo ObsInd
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

        /// <summary>Gets or sets the Remarks field. </summary>
        public String Remarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the RequestDate field. </summary>
        public Nullable<System.DateTime> RequestDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SequenceNo field. </summary>
        public System.Int32 SequenceNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WorkflowSerialNo field. </summary>
        public String WorkflowSerialNo
        {
            get;
            set;
        }

        public YesNo SyncRequired
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
            EMSAppointmentEntity toCompareWith = obj as EMSAppointmentEntity;
            return toCompareWith == null ? false : ((this.EMSAppointmentId == toCompareWith.EMSAppointmentId));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appointment"></param> 
        /// <returns>string</returns>
        public string GetApptOutcomeCode()
        {
            if (this.MEMSApptOutcome == null)
                return string.Empty;
            else
                return this.MEMSApptOutcome.EMSApptOutcomeCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appointment"></param> 
        /// <returns>string</returns>
        public string GetApptReasonCode()
        {
            if (this.MEMSApptReason == null)
                return string.Empty;
            else
                return this.MEMSApptReason.EMSApptReasonCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appointment"></param> 
        /// <returns>string</returns>
        public string GetApptTypeCode()
        {
            if (this.MEMSApptType == null)
                return string.Empty;
            else
                return this.MEMSApptType.EMSApptTypeCode;
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSAppointmentId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}