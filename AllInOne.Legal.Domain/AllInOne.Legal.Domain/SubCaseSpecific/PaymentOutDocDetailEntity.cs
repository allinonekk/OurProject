#region Header

/*****************************************************************************************************
* Description : This file represents a standard PaymentOutDocDetail entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   21/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: PaymentOutDocDetailEntity.cs
// Description: Represents a standard PaymentOutDocDetail entity.
// </summary>
// <copyright file= "PaymentOutDocDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for PaymentOutDocDetail.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class PaymentOutDocDetailEntity : AbstractSubmissionGroup, ISubCaseSpecificEntity
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
        /// Gets or sets the Amount field.
        /// </summary>
        /// <value>The amount.</value>
        public Decimal? Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Amount Approved field.
        /// </summary>
        /// <value>The amount approved.</value>
        public Decimal? AmountApproved
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Designation field.
        /// </summary>
        /// <value>The designation.</value>
        public String Designation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PartyName field.
        /// </summary>
        /// <value>The name of the party.</value>
        public String PartyName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PaymentOutID field.
        /// </summary>
        /// <value>The payment out ID.</value>
        public String PaymentOutID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the POReason field.
        /// </summary>
        /// <value>The PO reason.</value>
        public String POReason
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RefOrderDetail id.
        /// </summary>
        /// <value>The RefOrderDetail id.</value>
        public String RefOrderDetailId
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
        /// Gets or sets the PIRemarks field.
        /// </summary>
        /// <value>The remarks.</value>
        public String PIRemarks
        {
            get;
            set;
        }

        public MCurrencyEntity MCurrency
        {
            get;
            set;
        }

        public int? ItemNo { get; set; }
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

            PaymentOutDocDetailEntity toCompareWith = obj as PaymentOutDocDetailEntity;
            return toCompareWith == null ? false : ((this.PaymentOutID == toCompareWith.PaymentOutID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PaymentOutID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}