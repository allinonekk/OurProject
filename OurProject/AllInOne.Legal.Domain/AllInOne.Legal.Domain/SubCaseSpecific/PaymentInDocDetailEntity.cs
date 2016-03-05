#region Header

/*****************************************************************************************************
* Description : This file represents a standard PaymentInDocDetail entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   05/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: PaymentInDocDetailEntity.cs
// Description: Represents a standard PaymentInDocDetail entity.
// </summary>
// <copyright file= "PaymentInDocDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for PaymentInDocDetail.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class PaymentInDocDetailEntity : AbstractSubmissionGroup, ISubCaseSpecificEntity
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
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        public Decimal? Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the amount SGD.
        /// </summary>
        /// <value>The amount SGD.</value>
        public Decimal? AmountSGD
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HasTransferredOut field.
        /// </summary>
        /// <value>The has transferred out.</value>
        public YesNo HasTransferredOut
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the M currency.
        /// </summary>
        /// <value>The M currency.</value>
        public MCurrencyEntity MCurrency
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the paying in.
        /// </summary>
        /// <value>The type of the paying in.</value>
        public PayingInType PayingInType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the payment in id.
        /// </summary>
        /// <value>The payment in id.</value>
        public String PaymentInId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the payment in reason.
        /// </summary>
        /// <value>The payment in reason.</value>
        public PaymentInReasonType PaymentInReason
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        /// <value>The reason.</value>
        public String Reason
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ref order detail id.
        /// </summary>
        /// <value>The ref order detail id.</value>
        public String RefOrderDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RuleNo field.
        /// </summary>
        /// <value>The rule no.</value>
        public String RuleNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RuleOrderNo field.
        /// </summary>
        /// <value>The rule order no.</value>
        public String RuleOrderNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TransferredOutAmount field.
        /// </summary>
        /// <value>The transferred out amount.</value>
        public Decimal? TransferredOutAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the TransferredOutDate field.
        /// </summary>
        /// <value>The transferred out date.</value>
        public DateTime? TransferredOutDate
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

            PaymentInDocDetailEntity toCompareWith = obj as PaymentInDocDetailEntity;
            return toCompareWith == null ? false : ((this.PaymentInId == toCompareWith.PaymentInId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PaymentInId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}