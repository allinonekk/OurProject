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

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;

    /// <summary>
    /// Represents a standard domain entity for NoticeToReferAffidavitE.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class NoticeToReferAffidavit: ICommon
    {
        #region Properties


        /// <summary>
        /// Gets or sets the notice to refer id.
        /// </summary>
        /// <value>The notice to refer id.</value>
        public virtual string NoticeToReferId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the case no.
        /// </summary>
        /// <value>The case no.</value>
        public virtual string CaseNo
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the sub case no.
        /// </summary>
        /// <value>The sub case no.</value>
        public virtual string SubCaseNo
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the refer affidavit doc id.
        /// </summary>
        /// <value>The refer affidavit doc id.</value>
        public virtual string ReferAffidavitDocId
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the refer forum id.
        /// </summary>
        /// <value>The refer forum id.</value>
        public virtual string ReferForumId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the submission group id.
        /// </summary>
        /// <value>The submission group id.</value>
        public virtual string SubmissionGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified by.
        /// </summary>
        /// <value>The last modified by.</value>
        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last modified date.
        /// </summary>
        /// <value>The last modified date.</value>
        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        public virtual Int32 ItemNo
        {
            get;
            set;
        }

        public virtual string ReferAffidavitDocCode
        {
            get;
            set;
        }

        public virtual string ReferAffidavitDocTitle
        {
            get;
            set;
        }

        public virtual string IsDocArchived { get; set; }

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

            NoticeToReferAffidavit toCompareWith = obj as NoticeToReferAffidavit;
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