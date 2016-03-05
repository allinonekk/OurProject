#region Header

/*****************************************************************************************************
* Description : This file represents a standard WOEAppointment entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   24/08/2011  		      Chun Jie             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: WOEAppointmentEntity.cs
// Description: Represents a standard WOEAppointment entity.
// </summary>
// <copyright file= "WOEAppointmentEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'FrontEndSpecificEntity.WOEAppointmentEntity'</summary>
    public partial class WOEAppointmentEntity : IFrontEndSpecificEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="WOEAppointmentEntity"/> class.</summary>
        public WOEAppointmentEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the ExecAddr field. </summary>
        public String ExecAddr
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ExecDateTime field. </summary>
        public DateTime ExecDateTime
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public String LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public DateTime LastModifiedDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubCaseInfoID field. </summary>
        public Int64 SubCaseInfoID
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
            WOEAppointmentEntity toCompareWith = obj as WOEAppointmentEntity;
            return toCompareWith == null ? false : ((this.SubCaseInfoID == toCompareWith.SubCaseInfoID) && (this.ItemNo == toCompareWith.ItemNo));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SubCaseInfoID.GetHashCode();
            toReturn ^= this.ItemNo.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}