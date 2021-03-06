﻿#region Header

//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v3.0.</auto-generated>
//------------------------------------------------------------------------------

#endregion Header

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>Class which represents the entity 'Master.MEMSApptOutcome'</summary>
    public partial class MEMSApptOutcome : IMaster
    {
        #region Fields

        private System.String _description;
        //private System.Collections.Generic.ICollection<EMSAppointment> _eMSAppointments;
        private System.String _eMSApptOutcomeCode;
        private Nullable<System.Int32> _frequencyInd;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.Collections.Generic.ICollection<MEMSApptReason> _mEMSApptReasons;
        private MEMSApptType _mEMSApptType;
        private System.String _obsInd;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MEMSApptOutcome"/> class.</summary>
        public MEMSApptOutcome()
            : base()
        {
            //_eMSAppointments = new System.Collections.Generic.HashSet<EMSAppointment>();
            _mEMSApptReasons = new System.Collections.Generic.HashSet<MEMSApptReason>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSAppointment.MEMSApptOutcome - Master.MEMSApptOutcome.EMSAppointments (m:1)'</summary>
        //public virtual System.Collections.Generic.ICollection<EMSAppointment> EMSAppointments
        //{
        //    get { return _eMSAppointments; }
        //    set { _eMSAppointments = value; }
        //}

        /// <summary>Gets or sets the EMSApptOutcomeCode field. </summary>
        public virtual System.String EMSApptOutcomeCode
        {
            get { return _eMSApptOutcomeCode; }
            set { _eMSApptOutcomeCode = value; }
        }

        /// <summary>Gets or sets the FrequencyInd field. </summary>
        public virtual Nullable<System.Int32> FrequencyInd
        {
            get { return _frequencyInd; }
            set { _frequencyInd = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'Master.MEMSApptReason.MEMSApptOutcome - Master.MEMSApptOutcome.MEMSApptReasons (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<MEMSApptReason> MEMSApptReasons
        {
            get { return _mEMSApptReasons; }
            set { _mEMSApptReasons = value; }
        }

        /// <summary>Represents the navigator which is mapped onto the association 'Master.MEMSApptOutcome.MEMSApptType - Master.MEMSApptType.MEMSApptOutcomes (m:1)'</summary>
        public virtual MEMSApptType MEMSApptType
        {
            get { return _mEMSApptType; }
            set { _mEMSApptType = value; }
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public virtual System.String ObsInd
        {
            get { return _obsInd; }
            set { _obsInd = value; }
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
            MEMSApptOutcome toCompareWith = obj as MEMSApptOutcome;
            return toCompareWith == null ? false : ((this.EMSApptOutcomeCode == toCompareWith.EMSApptOutcomeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSApptOutcomeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}