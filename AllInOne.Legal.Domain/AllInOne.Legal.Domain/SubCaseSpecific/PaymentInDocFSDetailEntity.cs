#region Header

/*****************************************************************************************************
* Description : This file represents a standard PaymentInDocFSDetail entity.
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
// File: PaymentInDocFSDetailEntity.cs
// Description: Represents a standard PaymentInDocFSDetail entity.
// </summary>
// <copyright file= "PaymentInDocFSDetailEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for PaymentInDocFSDetail.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class PaymentInDocFSDetailEntity : AbstractSubmissionGroup, ISubCaseSpecificEntity
    {
        #region Properties

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
        /// Gets or sets the M currency.
        /// </summary>
        /// <value>The M currency.</value>
        public MCurrencyEntity MCurrency
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the particulars.
        /// </summary>
        /// <value>The particulars.</value>
        public String Particulars
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the payment in FSID.
        /// </summary>
        /// <value>The payment in FSID.</value>
        public String PaymentInFSID
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
        /// Gets or sets the persons directed.
        /// </summary>
        /// <value>The persons directed.</value>
        public String PersonsDirected
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the securities.
        /// </summary>
        /// <value>The securities.</value>
        public String Securities
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

            PaymentInDocFSDetailEntity toCompareWith = obj as PaymentInDocFSDetailEntity;
            return toCompareWith == null ? false : ((this.PaymentInFSID == toCompareWith.PaymentInFSID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.PaymentInFSID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}