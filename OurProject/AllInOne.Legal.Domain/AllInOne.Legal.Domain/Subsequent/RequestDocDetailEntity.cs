#region Header

/*****************************************************************************************************
 * Description : This file represents a standard RequestDocDetailEntity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 23/01/2011   		      Nithin             	 	Created
 *****************************************************************************************************/
// <summary>
// File: CDRInfoEntity.cs
// Description: Represents a standard RequestDocDetailEntity.
// </summary>
// <copyright file= "RequestDocDetailEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for RequestDocDetailEntity.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class RequestDocDetailEntity : AbstractLastModified, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AmtApproved field.
        /// </summary>
        /// <value>The amt approved.</value>
        public Decimal? AmtApproved
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AmtRequested field.
        /// </summary>
        /// <value>The amt requested.</value>
        public Decimal? AmtRequested
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BilledDate field.
        /// </summary>
        /// <value>The billed date.</value>
        public DateTime? BilledDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocId field.
        /// </summary>
        /// <value>The doc id.</value>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsInterfaced field.
        /// </summary>
        /// <value>The is interfaced.</value>
        public YesNo IsInterfaced
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Subsequent.RequestDocDetail.MFilingFee - Master.MFilingFee.RequestDocDetails (m:1)'
        /// </summary>
        /// <value>The M filing fee.</value>
        public MFilingFeeEntity MFilingFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NoOfCopies field.
        /// </summary>
        /// <value>The no of copies.</value>
        public Int32? NoOfCopies
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RefundFeeType field.
        /// </summary>
        /// <value>The type of the refund fee.</value>
        public RefundFeeType RefundFeeType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RefundStatus field.
        /// </summary>
        /// <value>The refund status.</value>
        public RefundStatus RefundStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RefundType field.
        /// </summary>
        /// <value>The type of the refund.</value>
        public RefundType RefundType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RequestDocId field.
        /// </summary>
        /// <value>The request doc id.</value>
        public String RequestDocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Type field.
        /// </summary>
        /// <value>The type.</value>
        public RequestType Type
        {
            get;
            set;
        }

        public string FilingPartyInfo
        {
            get;
            set;
        }

        public string ReasonforRefund
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
            RequestDocDetailEntity toCompareWith = obj as RequestDocDetailEntity;
            return toCompareWith == null ? false : ((this.DocId == toCompareWith.DocId) && (this.RequestDocId == toCompareWith.RequestDocId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocId.GetHashCode();
            toReturn ^= this.RequestDocId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}