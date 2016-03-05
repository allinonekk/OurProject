#region Header

/*****************************************************************************************************
 * Description : This file represents a standard RCaseLinked.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 04/10/2010   		      Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: RCaseLinkedEntity.cs
// Description: Represents a standard RCaseLinked.
// </summary>
// <copyright file= "RCaseLinkedEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for RCaseLinked.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class RCaseTransferEntity : AbstractLastModified, ICaseEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RCaseLinkedEntity"/> class.
        /// </summary>
        public RCaseTransferEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the LinkGroupId field. </summary>
        public String FrCaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LinkedDate field. </summary>
        public String FrCaseNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LinkedDate field. </summary>
        public String FrForum
        {
            get;
            set;
        }

        public String RCaseTransferId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public DateTime ReqForTransferDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CrossCourtInd field. </summary>
        public String ToCaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LinkedDate field. </summary>
        public String ToCaseNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LinkedDate field. </summary>
        public String ToForum
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public DateTime TransferDate
        {
            get;
            set;
        }

        /// <summary>Gets or sets the TransferRequestedBy field. </summary>
        public string TransferRequestedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfOrder field. </summary>
        public Nullable<DateTime> DateOfOrder
        {
            get;
            set;
        }

        public string TransferOrderOfCourtId
        {
            get;
            set;
        }

        public PaymentMode FrCasePaymentMode
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

            RCaseTransferEntity toCompareWith = obj as RCaseTransferEntity;
            return toCompareWith == null ? false : (this.RCaseTransferId == toCompareWith.RCaseTransferId);
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RCaseTransferId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}