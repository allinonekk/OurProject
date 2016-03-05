#region Header

/*****************************************************************************************************
* Description : This file represents a standard NotPaymenttoCourtDocDetail Entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   02/11/2010   		      Rajeev             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: NotPaymenttoCourtDocDetailEntity.cs
// Description: Represents a standard NotPaymenttoCourtDocDetail Entity.
// </summary>
// <copyright file= "NotPaymenttoCourtDocDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for NotPaymenttoCourtDocDetail.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class NotPaymenttoCourtDocDetailEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

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
        /// Gets or sets the AmountSGD field.
        /// </summary>
        /// <value>The amount SGD.</value>
        public Decimal? AmountSGD
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.NotPaymenttoCourtDocDetail.MCurrency - Master.MCurrency.NotPaymenttoCourtDocDetails (m:1)'
        /// </summary>
        /// <value>The M currency.</value>
        public MCurrencyEntity MCurrency
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NotPayeCourtDetailId field.
        /// </summary>
        /// <value>The not paye court detail id.</value>
        public String NotPayeCourtDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.NotPaymenttoCourtDocDetail.PaymentInId - Document.PaymentIn.NotPaymenttoCourtDocDetails (m:1)'
        /// </summary>
        /// <value>The payment in id.</value>
        public String PaymentInId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Reason field.
        /// </summary>
        /// <value>The reason.</value>
        public String Reason
        {
            get;
            set;
        }

        public decimal? PIAmount
        {
            get;
            set;
        }

        public MCurrencyEntity PICurrencyCode
        {
            get;
            set;
        }

        public string EFSPayInNumber
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
            if (obj == null)
                {
                return false;
                }
            NotPaymenttoCourtDocDetailEntity toCompareWith = obj as NotPaymenttoCourtDocDetailEntity;
            return toCompareWith == null ? false : ((this.NotPayeCourtDetailId == toCompareWith.NotPayeCourtDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NotPayeCourtDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}