#region Header

/*****************************************************************************************************
 * Description : This file represents a standard NoticeToReferAffidavit entity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 31/05/2011                 Nithin             	 	Created
 ******************************************************************************************************/
// <summary>
// File: NoticeToReferAffidavitEntity.cs
// Description: Represents a standard NoticeToReferAffidavit entity.
// </summary>
// <copyright file= "NoticeToReferAffidavitEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for NoticeToReferAffidavitE.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class NoticeToReferAffidavitEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AEICType field.
        /// </summary>
        /// <value>The type of the AEIC.</value>
        public string NoticeToReferId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the AffidavitId field.
        /// </summary>
        /// <value>The affidavit id.</value>
        public string CaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupId field.
        /// </summary>
        /// <value>The submission group id.</value>
        public string SubCaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SwornDate field.
        /// </summary>
        /// <value>The sworn date.</value>
        public string ReferAffidavitDocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the has filed summons.
        /// </summary>
        /// <value>The has filed summons.</value>
        public string ReferForumId
        {
            get;
            set;
        }

        public Int32 ItemNo
        {
            get;
            set;
        }

        public string ReferAffidavitDocCode
        {
            get;
            set;
        }

        public string ReferAffidavitDocTitle
        {
            get;
            set;
        }
        public YesNo IsDocArchived { get; set; }

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

            NoticeToReferAffidavitEntity toCompareWith = obj as NoticeToReferAffidavitEntity;
            return toCompareWith == null ? false : ((this.NoticeToReferId == toCompareWith.NoticeToReferId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NoticeToReferId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}