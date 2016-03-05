#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMHRGTypeHRGSlot entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   06/04/2011   		      Nithin             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: RMHRGTypeHRGSlotEntity.cs
// Description: Represents a standard RMHRGTypeHRGSlot entity.
// </summary>
// <copyright file= "RMHRGTypeHRGSlotEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.RMHRGTypeHRGSlotEntity'</summary>
    [Serializable]
    public class RMHRGTypeHRGSlotEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the CourtInd field. </summary>
        public String CourtInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGSlotCode field. </summary>
        public String HRGSlotCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGTypeCode field. </summary>
        public String HRGTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsInterfaced field. </summary>
        public String IsInterfaced
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
            if (obj == null)
            {
                return false;
            }
            RMHRGTypeHRGSlotEntity toCompareWith = obj as RMHRGTypeHRGSlotEntity;
            return toCompareWith == null ? false : ((this.CourtInd == toCompareWith.CourtInd) && (this.HRGTypeCode == toCompareWith.HRGTypeCode) && (this.HRGSlotCode==toCompareWith.HRGSlotCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CourtInd.GetHashCode();
            toReturn ^= this.HRGTypeCode.GetHashCode();
            toReturn ^= this.HRGSlotCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}