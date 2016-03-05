#region Header

/*****************************************************************************************************
* Description : This file represents a standard CertSecurityOfCostsInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   30/12/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CertSecurityOfCostsInfoEntity.cs
// Description: Represents a standard CertSecurityOfCostsInfo entity.
// </summary>
// <copyright file= "CertSecurityOfCostsInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for CertSecurityOfCostsInfo.
    /// It inherits from <see cref="AbstractDocIdSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class CertSecurityOfCostsInfoEntity : AbstractDocIdSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CertSecurityOfCostsInfoId field.
        /// </summary>
        /// <value>The cert security of costs info id.</value>
        public String CertSecurityOfCostsInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DRIAmount field.
        /// </summary>
        /// <value>The DRI amount.</value>
        public Decimal? DRIAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DRINumber field.
        /// </summary>
        /// <value>The DRI number.</value>
        public String DRINumber
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

            CertSecurityOfCostsInfoEntity toCompareWith = obj as CertSecurityOfCostsInfoEntity;
            return toCompareWith == null ? false : ((this.CertSecurityOfCostsInfoId == toCompareWith.CertSecurityOfCostsInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CertSecurityOfCostsInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}