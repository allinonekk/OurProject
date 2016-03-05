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

    /// <summary>Class which represents the entity 'Master.MEMSApptType'</summary>
    public partial class MEMSApptType : IMaster
    {
        #region Fields

        private System.String _description;
        //private System.Collections.Generic.ICollection<EMSAppointment> _eMSAppointments;
        private System.String _eMSApptTypeCode;
        private Nullable<System.Int32> _frequencyInd;
        private System.String _lastModifiedBy;
        private System.DateTime _lastModifiedDate;
        private System.Collections.Generic.ICollection<MEMSApptOutcome> _mEMSApptOutcomes;
        private System.String _obsInd;

        #endregion Fields

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MEMSApptType"/> class.</summary>
        public MEMSApptType()
            : base()
        {
            //_eMSAppointments = new System.Collections.Generic.HashSet<EMSAppointment>();
            _mEMSApptOutcomes = new System.Collections.Generic.HashSet<MEMSApptOutcome>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the Description field. </summary>
        public virtual System.String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        ///// <summary>Represents the navigator which is mapped onto the association 'Enforcement.EMSAppointment.MEMSApptType - Master.MEMSApptType.EMSAppointments (m:1)'</summary>
        //public virtual System.Collections.Generic.ICollection<EMSAppointment> EMSAppointments
        //{
        //    get { return _eMSAppointments; }
        //    set { _eMSAppointments = value; }
        //}

        /// <summary>Gets or sets the EMSApptTypeCode field. </summary>
        public virtual System.String EMSApptTypeCode
        {
            get { return _eMSApptTypeCode; }
            set { _eMSApptTypeCode = value; }
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

        /// <summary>Represents the navigator which is mapped onto the association 'Master.MEMSApptOutcome.MEMSApptType - Master.MEMSApptType.MEMSApptOutcomes (m:1)'</summary>
        public virtual System.Collections.Generic.ICollection<MEMSApptOutcome> MEMSApptOutcomes
        {
            get { return _mEMSApptOutcomes; }
            set { _mEMSApptOutcomes = value; }
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
            MEMSApptType toCompareWith = obj as MEMSApptType;
            return toCompareWith == null ? false : ((this.EMSApptTypeCode == toCompareWith.EMSApptTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EMSApptTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}