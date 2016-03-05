#region Header

/*****************************************************************************************************
 * Description : This file represents a PaymentOutDocDetailManual entity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 30/12/2010                 Swaroop           	 	Created
 *****************************************************************************************************/
// <summary>
// File: PaymentOutDocDetailManualEntity.cs
// Description: Represents a PaymentOutDocDetailManual entity.
// </summary>
// <copyright file= "PaymentOutDocDetailManualEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for PaymentOutDocDetailManual.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class PaymentOutDocDetailManualEntity : AbstractCaseInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AGRefNumber field.
        /// </summary>
        /// <value>The AG ref number.</value>
        public String AGRefNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AmountSGD field.
        /// </summary>
        /// <value>The amount SGD.</value>
        public Decimal? AmountSGD
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PaymentOutManualId field.
        /// </summary>
        /// <value>The payment out manual id.</value>
        public String PaymentOutManualId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Remarks field.
        /// </summary>
        /// <value>The remarks.</value>
        public String Remarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseNo field.
        /// </summary>
        /// <value>The sub case no.</value>
        public String SubCaseNo
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

            PaymentOutDocDetailManualEntity toCompareWith = obj as PaymentOutDocDetailManualEntity;
            return toCompareWith == null ? false : ((this.PaymentOutManualId == toCompareWith.PaymentOutManualId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PaymentOutManualId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}