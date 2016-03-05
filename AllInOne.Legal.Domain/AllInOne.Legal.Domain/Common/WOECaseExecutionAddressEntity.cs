#region Header

/*****************************************************************************************************
* Description : This file represents a standard WOECaseExecutionAddress entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   31/05/2011   		      CJ                 	 	Created
*
*****************************************************************************************************/
// <summary>
// File: WOECaseExecutionAddressEntity.cs
// Description: Represents a standard WOECaseExecutionAddress entity.
// </summary>
// <copyright file= "WOECaseExecutionAddressEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Common.WOECaseExecutionAddressEntity'</summary>
    [Serializable]
    public partial class WOECaseExecutionAddressEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the Addr1 field. </summary>
        public System.String Addr1
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr2 field. </summary>
        public System.String Addr2
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr3 field. </summary>
        public System.String Addr3
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr4 field. </summary>
        public System.String Addr4
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Address field. </summary>
        public System.String Address
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BlkNo field. </summary>
        public System.String BlkNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BuildingName field. </summary>
        public System.String BuildingName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseInfoId field. </summary>
        public System.Int64 CaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FloorNo field. </summary>
        public System.String FloorNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FormatInd field. </summary>
        public System.String FormatInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public System.Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PostalCode field. </summary>
        public System.String PostalCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the StreetName field. </summary>
        public System.String StreetName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubCaseInfoId field. </summary>
        public Nullable<System.Int64> SubCaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UnitNo field. </summary>
        public System.String UnitNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WOECaseExecutionAddressId field. </summary>
        public System.String WOECaseExecutionAddressId
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
            WOECaseExecutionAddressEntity toCompareWith = obj as WOECaseExecutionAddressEntity;
            return toCompareWith == null ? false : ((this.WOECaseExecutionAddressId == toCompareWith.WOECaseExecutionAddressId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WOECaseExecutionAddressId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}