#region Header

/*****************************************************************************************************
* Description : This file represents a standard PaymentHRGDatesDocDetailInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   24/09/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: PaymentHRGDatesDocDetailInfoEntity.cs
// Description: Represents a standard PaymentHRGDatesDocDetailInfo entity.
// </summary>
// <copyright file= "PaymentHRGDatesDocDetailInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for PaymentHRGDatesDocDetailInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class PaymentHRGDatesDocDetailEntity : AbstractSubmissionGroup, ISubsequentEntity
    {
        #region Properties

        public decimal? Amount
        {
            get;
            set;
        }

        public MHRGBeforeTypeEntity MHRGBeforeType
        {
            get;
            set;
        }

        public Int32? NoOfHRGDays
        {
            get;
            set;
        }

        public Int32? NoOfUsedHRGDays
        {
            get;
            set;
        }

        public string PayHRGDocId
        {
            get;
            set;
        }

        public Int32? HRGWitnesses
        {
            get;
            set;
        }

        public Int32? HRGHours
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

            PaymentHRGDatesDocDetailEntity toCompareWith = obj as PaymentHRGDatesDocDetailEntity;
            return toCompareWith == null ? false : ((this.PayHRGDocId == toCompareWith.PayHRGDocId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PayHRGDocId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}