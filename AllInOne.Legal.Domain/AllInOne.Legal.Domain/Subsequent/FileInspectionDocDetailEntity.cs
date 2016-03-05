#region Header

/*****************************************************************************************************
 * Description : This file represents a standard FileInspectionDocDetailsEntity.
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
// File: FileInspectionDocDetailsEntity.cs
// Description: Represents a standard FileInspectionDocDetailsEntity.
// </summary>
// <copyright file= "FileInspectionDocDetailsEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for FileInspectionDocDetailsEntity.
    /// It inherits from <see cref="AbstractCaseInfoSubCaseInfoDocId"/>
    /// </summary>
    [Serializable]
    public class FileInspectionDocDetailEntity : AbstractCaseInfoSubCaseInfoDocId, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the file inspection id.
        /// </summary>
        /// <value>The file inspection id.</value>
        public String FileInspectionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        public FileInspectionDocStatus Status
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
            FileInspectionDocDetailEntity toCompareWith = obj as FileInspectionDocDetailEntity;
            return toCompareWith == null ? false : ((this.CaseInfoId == toCompareWith.CaseInfoId) && (this.DocId == toCompareWith.DocId) && (this.FileInspectionId == toCompareWith.FileInspectionId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseInfoId.GetHashCode();
            toReturn ^= this.DocId.GetHashCode();
            toReturn ^= this.FileInspectionId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}