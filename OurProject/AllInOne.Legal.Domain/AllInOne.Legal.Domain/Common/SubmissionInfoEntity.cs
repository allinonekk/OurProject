#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for SubmissionInfo.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   19/12/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: SubmissionInfoEntity.cs
// Description: Represents a standard domain entity for SubmissionInfo.
// </summary>
// <copyright file= "SubmissionInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for SubmissionInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class SubmissionInfoEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AccountId field.
        /// </summary>
        /// <value>The account id.</value>
        public String AccountId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ETA field.
        /// </summary>
        /// <value>The ETA.</value>
        public String ETA
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.SubmissionInfo.LawFirm - Common.LawFirm.SubmissionInfos (m:1)'
        /// </summary>
        /// <value>The LFID.</value>
        public String LFID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Stage field.
        /// </summary>
        /// <value>The stage.</value>
        public SubmissionStage Stage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmissionNumber field.
        /// </summary>
        /// <value>The submission number.</value>
        public String SubmissionNumber
        {
            get;
            set;
        }

        public YesNo IsCaseArchived
        {
            get;
            set;
        }

        public String LFAccountIdToCharge
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

            SubmissionInfoEntity toCompareWith = obj as SubmissionInfoEntity;
            return toCompareWith == null ? false : ((this.SubmissionGroupId == toCompareWith.SubmissionGroupId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SubmissionGroupId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}