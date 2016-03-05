#region Header

/*****************************************************************************************************
 * Description : This file represents a PaymentInDocDetailManual entity.
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
// File: PaymentInDocDetailManualEntity.cs
// Description: Represents a PaymentInDocDetailManual entity.
// </summary>
// <copyright file= "PaymentInDocDetailManualEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for PaymentInDocDetailManual.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class PaymentInDocDetailManualEntity : AbstractCaseInfo
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
        /// Gets or sets the HasTransferredOut field.
        /// </summary>
        /// <value>The has transferred out.</value>
        public YesNo HasTransferredOut
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
        /// Gets or sets the PaymentInManualId field.
        /// </summary>
        /// <value>The payment in manual id.</value>
        public String PaymentInManualId
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
            PaymentInDocDetailManualEntity toCompareWith = obj as PaymentInDocDetailManualEntity;
            return toCompareWith == null ? false : ((this.PaymentInManualId == toCompareWith.PaymentInManualId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PaymentInManualId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}