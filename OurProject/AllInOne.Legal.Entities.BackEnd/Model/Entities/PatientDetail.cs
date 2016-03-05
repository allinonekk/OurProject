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

    /// <summary>Class which represents the entity 'BackEndSpecific.ADIADetail'</summary>
    public partial class PatientDetail
    {
      

        #region Properties

        public virtual String Addr1
        {
            get;
            set;
        }

        public virtual String Addr2
        {
            get;
            set;
        }

        public virtual String Addr3
        {
            get;
            set;
        }

        public virtual String Addr4
        {
            get;
            set;
        }

        public virtual String BlkNo
        {
            get;
            set;
        }

        public virtual String BuildingName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is injunction filed.
        /// </summary>
        /// <value>The is injunction filed.</value>
        public virtual Nullable<DateTime> DateOfBirth
        {
            get;
            set;
        }

        public virtual String FloorNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the total LIQ awarded amount.
        /// </summary>
        /// <value>The total LIQ awarded amount.</value>
        public virtual String FormatInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is serve out JDC.
        /// </summary>
        /// <value>The is serve out JDC.</value>
        public virtual String IdNumber
        {
            get;
            set;
        }

        public virtual String IdRemarks
        {
            get;
            set;
        }

        public virtual MAccomodationType MAccomodationType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is partner in firm.
        /// </summary>
        /// <value>The is partner in firm.</value>
        public virtual MCountry MCountry
        {
            get;
            set;
        }

        public virtual MMaritalStatus MMaritalStatus
        {
            get;
            set;
        }

        public virtual MOccupation MOccupation
        {
            get;
            set;
        }

        public virtual MPersonIDGroup MPersonIDGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is managed EWT.
        /// </summary>
        /// <value>The is managed EWT.</value>
        public virtual MPersonIDType MPersonIDType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the control.
        /// </summary>
        /// <value>The type of the control.</value>
        public virtual String Name
        {
            get;
            set;
        }

        public virtual Nullable<Int32> NoOfRevPersons
        {
            get;
            set;
        }

        public virtual String OtherAccommodation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the attachment.
        /// </summary>
        /// <value>The type of the attachment.</value>
        public virtual String PatientId
        {
            get;
            set;
        }

        public virtual String PostalCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the total LIQ claim amount.
        /// </summary>
        /// <value>The total LIQ claim amount.</value>
        public virtual String ResAddress
        {
            get;
            set;
        }

        public virtual String StreetName
        {
            get;
            set;
        }

        public virtual String UnitNo
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
            PatientDetail toCompareWith = obj as PatientDetail;
            return toCompareWith == null ? false : ((this.PatientId == toCompareWith.PatientId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PatientId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}