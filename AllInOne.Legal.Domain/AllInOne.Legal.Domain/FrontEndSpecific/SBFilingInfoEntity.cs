#region Header

/*****************************************************************************************************
* Description : This file represents a standard SBFilingInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   04/01/2011  		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: SBFilingInfoEntity.cs
// Description: Represents a standard SBFilingInfo entity.
// </summary>
// <copyright file= "SBFilingInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for SBFilingInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class SBFilingInfoEntity : AbstractSubmissionGroup, IFrontEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AcknowledgementSlipNo field.
        /// </summary>
        /// <value>The acknowledgement slip no.</value>
        public String AcknowledgementSlipNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Email field.
        /// </summary>
        /// <value>The email.</value>
        public String Email
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MobileNumber field.
        /// </summary>
        /// <value>The mobile number.</value>
        public String MobileNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OtherFee field.
        /// </summary>
        public Decimal? OtherFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PhotocopyingFee field.
        /// </summary>
        public Decimal? PhotocopyingFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SBFilingInfoId field.
        /// </summary>
        /// <value>The SB filing info id.</value>
        public String SBFilingInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SBRemarks field.
        /// </summary>
        /// <value>The SB remarks.</value>
        public String SBRemarks
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
            SBFilingInfoEntity toCompareWith = obj as SBFilingInfoEntity;
            return toCompareWith == null ? false : ((this.SBFilingInfoId == toCompareWith.SBFilingInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SBFilingInfoId.GetHashCode();
            return toReturn;
        }

        public override string ToString()
        {
            return "--SBFilingInfoId=" + SBFilingInfoId == null ? "" : SBFilingInfoId +
                   "--SubmissionGroupId=" + SubmissionGroupId == null ? "" : SubmissionGroupId+
                   "--AcknowledgementSlipNo=" + AcknowledgementSlipNo == null ? "" : AcknowledgementSlipNo+
                   "--MobileNumber=" + MobileNumber == null ? "" : MobileNumber+
                   "--Email=" + Email == null ? "" : Email+
                   "--SBRemarks=" + SBRemarks == null ? "" : SBRemarks+
                   "--PhotocopyingFee=" + PhotocopyingFee == null ? "" : PhotocopyingFee +
                   "--OtherFee=" + OtherFee == null ? "" : OtherFee +
                   "--LastModifiedBy=" + LastModifiedBy == null ? "" : LastModifiedBy +
                   "--LastModifiedDate=" + LastModifiedDate;
        }

        #endregion Methods
    }
}