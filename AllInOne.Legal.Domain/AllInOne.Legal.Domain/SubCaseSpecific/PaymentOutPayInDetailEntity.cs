#region Header

/*****************************************************************************************************
* Description : This file represents a standard PaymentOutPayInDetail entity.
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
// File: PaymentOutPayInDetailEntity.cs
// Description: Represents a standard PaymentOutPayInDetail entity.
// </summary>
// <copyright file= "PaymentOutPayInDetailEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for PaymentOutPayInDetail.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class PaymentOutPayInDetailEntity : AbstractSubmissionGroup, ISubCaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AmountOut field.
        /// </summary>
        /// <value>The amount out.</value>
        public Decimal? AmountOut
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the case info id.
        /// </summary>
        /// <value>The case info id.</value>
        public Int64? CaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the case no.
        /// </summary>
        /// <value>The case no.</value>
        public String CaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsBackEndUserAdded field.
        /// </summary>
        /// <value>The transferred out date.</value>
        public YesNo IsBackEndUserAdded
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'PaymentOut.PaymentOutPayInDetail.MCourtType - Master.MCourtType.PaymentOutPayInDetails (m:1)'
        /// </summary>
        /// <value>The type of the M court.</value>
        public MCourtTypeEntity MCourtType
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
        /// Gets or sets the PaymentOutID field.
        /// </summary>
        /// <value>The payment out ID.</value>
        public String PaymentOutID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PaymentOutInID field.
        /// </summary>
        /// <value>The payment out in ID.</value>
        public String PaymentOutInID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The sub case info id.</value>
        public Int64? SubCaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the sub case no.
        /// </summary>
        /// <value>The sub case no.</value>
        public String SubCaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CurrencyCode.
        /// </summary>
        /// <value>The CurrencyCode.</value>
        public String CurrencyCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CurrencyDescription.
        /// </summary>
        /// <value>The CurrencyDescription.</value>
        public String CurrencyDescription
        {
            get;
            set;
        }

        public MCurrencyEntity MCurrency { get; set; }

        public int? ItemNo{ get; set; }

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

            PaymentOutPayInDetailEntity toCompareWith = obj as PaymentOutPayInDetailEntity;
            return toCompareWith == null ? false : ((this.PaymentOutInID == toCompareWith.PaymentOutInID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PaymentOutInID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}