#region Header

/*****************************************************************************************************
* Description : This file represents a standard BillOfSaleSubInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   22/11/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: BillOfSaleSubInfoEntity.cs
// Description: Represents a standard BillOfSaleSubInfo entity.
// </summary>
// <copyright file= "BillOfSaleSubInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for BillOfSaleSubInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class BillOfSaleSubInfoEntity : AbstractSubmissionGroup, ISubsequentEntity
    {
        #region Properties

        /// <summary>Gets or sets the BillOfSaleSubInfoId field. </summary>
        public String BillOfSaleSubInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the InstrumentDate field. </summary>
        public DateTime? InstrumentDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsSeekingBorrower field. </summary>
        public YesNo IsSeekingBorrower
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsSeekingInstrumentDate field. </summary>
        public YesNo IsSeekingInstrumentDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsSeekingLeaveOfCourt field. </summary>
        public YesNo IsSeekingLeaveOfCourt
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsSeekingLender field. </summary>
        public YesNo IsSeekingLender
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsSeekingOthers field. </summary>
        public YesNo IsSeekingOthers
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OtherText field. </summary>
        public String OtherText
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SatisfactionDate field. </summary>
        public Nullable<System.DateTime> SatisfactionDate
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

            BillOfSaleSubInfoEntity toCompareWith = obj as BillOfSaleSubInfoEntity;
            return toCompareWith == null ? false : ((this.BillOfSaleSubInfoId == toCompareWith.BillOfSaleSubInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BillOfSaleSubInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}