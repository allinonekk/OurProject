#region Header

/*****************************************************************************************************
 * Description : This file represents a standard RequestHearingFeeDetail entity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 28/02/2011   		      Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: RequestHearingFeeDetailEntity.cs
// Description: Represents a standard RequestHearingFeeDetail entity.
// </summary>
// <copyright file= "RequestHearingFeeDetailEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for RequestHearingFeeDetail entity.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class RequestHearingFeeDetailEntity : AbstractSubmissionGroup, ISubsequentEntity
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
        /// Gets or sets the amt computed.
        /// </summary>
        /// <value>The amt computed.</value>
        public Decimal? AmtComputed
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
        /// Gets or sets the CasePartyId
        /// </summary>
        /// <value>The CasePartyId.</value>
        public String CasePartyId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the deferred to.
        /// </summary>
        /// <value>The deferred to.</value>
        public DateTime? DeferredTo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGID field.
        /// </summary>
        /// <value>The HRGID.</value>
        public Int64? HRGID
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
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public int ItemNo
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
        /// Gets or sets the type of the waiver.
        /// </summary>
        /// <value>The type of the waiver.</value>
        public RefundOrWaiverStatus RefundOrWaiverStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the waiver.
        /// </summary>
        /// <value>The type of the waiver.</value>
        public RefundOrWaiverType RefundOrWaiverType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the request hearing fee detail id.
        /// </summary>
        /// <value>The request hearing fee detail id.</value>
        public String RequestHearingFeeDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the request FilingPartyInfo.
        /// </summary>
        /// <value>The request FilingPartyInfo.</value>
        public String FilingPartyInfo
        {
            get;
            set;
        }

        public DateTime? AllowedDefermentDate
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

            RequestHearingFeeDetailEntity toCompareWith = obj as RequestHearingFeeDetailEntity;
            return toCompareWith == null ? false : ((this.RequestHearingFeeDetailId == toCompareWith.RequestHearingFeeDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RequestHearingFeeDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}