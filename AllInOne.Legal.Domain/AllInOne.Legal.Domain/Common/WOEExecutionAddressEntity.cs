#region Header

/*****************************************************************************************************
* Description : This file represents a standard WOEExecutionAddress entity.
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
// File: WOEExecutionAddressEntity.cs
// Description: Represents a standard WOEExecutionAddress entity.
// </summary>
// <copyright file= "WOEExecutionAddressEntity.cs" company="AllInOne Pte Ltd">
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

    /// <summary>Class which represents the entity 'Common.WOEExecutionAddressEntity'</summary>
    [Serializable]
    public partial class WOEExecutionAddressEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>Gets or sets the Addr1 field. </summary>
        public String Addr1
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr2 field. </summary>
        public String Addr2
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr3 field. </summary>
        public String Addr3
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Addr4 field. </summary>
        public String Addr4
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Address field. </summary>
        public String Address
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BlkNo field. </summary>
        public String BlkNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the BuildingName field. </summary>
        public String BuildingName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FloorNo field. </summary>
        public String FloorNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FormatInd field. </summary>
        public AddressFormatType FormatInd
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

        /// <summary>Gets or sets the ObsInd field. </summary>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PostalCode field. </summary>
        public String PostalCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the StreetName field. </summary>
        public String StreetName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UnitNo field. </summary>
        public String UnitNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WOEExecutionAddressId field. </summary>
        public String WOEExecutionAddressId
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
            WOEExecutionAddressEntity toCompareWith = obj as WOEExecutionAddressEntity;
            return toCompareWith == null ? false : ((this.WOEExecutionAddressId == toCompareWith.WOEExecutionAddressId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WOEExecutionAddressId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}