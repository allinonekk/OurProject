#region Header

/*****************************************************************************************************
* Description : This file represents a standard CriminalOtherOrderInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   20/01/2011   		      CJ                 	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CriminalOtherOrderInfoEntity.cs
// Description: Represents a standard CriminalOtherOrderInfo entity.
// </summary>
// <copyright file= "CriminalOtherOrderInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'CaseSpecific.CriminalOtherOrderInfo'</summary>
    [Serializable]
    public class CriminalOtherOrderInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the CriminalOtherOrderInfoId field. </summary>
        public String CriminalOtherOrderInfoId
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

        /// <summary>Gets or sets the OtherOrder field. </summary>
        public String OtherOrder
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OtherSentence field. </summary>
        public String OtherSentence
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
            CriminalOtherOrderInfoEntity toCompareWith = obj as CriminalOtherOrderInfoEntity;
            return toCompareWith == null ? false : ((this.CriminalOtherOrderInfoId == toCompareWith.CriminalOtherOrderInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CriminalOtherOrderInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}