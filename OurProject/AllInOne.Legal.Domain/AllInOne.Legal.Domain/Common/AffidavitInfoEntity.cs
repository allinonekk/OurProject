#region Header

/*****************************************************************************************************
 * Description : This file represents a standard AffidavitInfo entity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 14/10/2010                 Swaroop             	 	Updated to strongly typed.
 ******************************************************************************************************/
// <summary>
// File: AffidavitInfoEntity.cs
// Description: Represents a standard AffidavitInfo entity.
// </summary>
// <copyright file= "AffidavitInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for AffidavitInfo.
    /// It inherits from <see cref="AbstractCaseInfoSubCaseInfoDocId"/>
    /// </summary>
    [Serializable]
    public class AffidavitInfoEntity : AbstractCaseInfoSubCaseInfoDocId, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AEICType field.
        /// </summary>
        /// <value>The type of the AEIC.</value>
        public AffidavitAEICType AEICType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the AffidavitId field.
        /// </summary>
        /// <value>The affidavit id.</value>
        public Int64 AffidavitId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group id.</value>
        public String SubmissionGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SwornDate field.
        /// </summary>
        /// <value>The sworn date.</value>
        public Nullable<DateTime> SwornDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the has filed summons.
        /// </summary>
        /// <value>The has filed summons.</value>
        public YesNo HasFiledSummons
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

            AffidavitInfoEntity toCompareWith = obj as AffidavitInfoEntity;
            return toCompareWith == null ? false : ((this.AffidavitId == toCompareWith.AffidavitId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AffidavitId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}