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

    /// <summary>Class which represents the entity 'BackEndSpecific.DCADetail'</summary>
    public partial class DeputyDetail : ICommon
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="DCADetail"/> class.</summary>
        public DeputyDetail()
            : base()
        {
        }

        #endregion Constructors

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

        /// <summary>
        /// Gets or sets the type of the attachment.
        /// </summary>
        /// <value>The type of the attachment.</value>
        public virtual String DeputyId
        {
            get;
            set;
        }

        public virtual String Email
        {
            get;
            set;
        }

        public virtual String EmpAddr1
        {
            get;
            set;
        }

        public virtual String EmpAddr2
        {
            get;
            set;
        }

        public virtual String EmpAddr3
        {
            get;
            set;
        }

        public virtual String EmpAddr4
        {
            get;
            set;
        }

        public virtual String EmpAddress
        {
            get;
            set;
        }

        public virtual String EmpBlkNo
        {
            get;
            set;
        }

        public virtual String EmpBuildingName
        {
            get;
            set;
        }

        public virtual String EmpFloorNo
        {
            get;
            set;
        }

        public virtual String EmpFormatInd
        {
            get;
            set;
        }

        public virtual String EmpName
        {
            get;
            set;
        }

        public virtual String EmpPostalCode
        {
            get;
            set;
        }

        public virtual String EmpStreetName
        {
            get;
            set;
        }

        public virtual String EmpUnitNo
        {
            get;
            set;
        }

        public virtual String FaxAreaCode
        {
            get;
            set;
        }

        public virtual String FaxCountryCode
        {
            get;
            set;
        }

        public virtual String FaxNumber
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

        public virtual String IDRemarks
        {
            get;
            set;
        }

        public virtual String LastModifiedBy
        {
            get;
            set;
        }

        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is partner in firm.
        /// </summary>
        /// <value>The is partner in firm.</value>
        public virtual String MCountry
        {
            get;
            set;
        }

        public virtual String MobileCountryCode
        {
            get;
            set;
        }

        public virtual String MobileNumber
        {
            get;
            set;
        }

        public virtual String MOccupation
        {
            get;
            set;
        }

        public virtual String MPersonIDGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is managed EWT.
        /// </summary>
        /// <value>The is managed EWT.</value>
        public virtual String MPersonIDType
        {
            get;
            set;
        }

        public virtual String MRelationship
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

        public virtual String PostalCode
        {
            get;
            set;
        }

        public virtual String RelationshipRemarks
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

        public virtual String SubmissionGroupId
        {
            get;
            set;
        }

        public virtual String TelAreaCode
        {
            get;
            set;
        }

        public virtual String TelCountryCode
        {
            get;
            set;
        }

        public virtual String TelNumber
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
            DeputyDetail toCompareWith = obj as DeputyDetail;
            return toCompareWith == null ? false : ((this.DeputyId == toCompareWith.DeputyId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DeputyId.GetHashCode();
            return toReturn;
        }

        #endregion Methods

        #region Other

        //private System.String _leaveToAppeal;
        //private System.String _dCADetailId;
        //private System.String _submissionGroupId;
        //private System.String _isAppealFiledCorrectly;

        #endregion Other
    }
}