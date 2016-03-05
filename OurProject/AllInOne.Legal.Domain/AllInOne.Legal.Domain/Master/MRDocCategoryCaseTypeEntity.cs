#region Header

/*****************************************************************************************************
* Description : This file represents a standard MRDocCategoryCaseType entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   26/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MRDocCategoryCaseTypeEntity.cs
// Description: Represents a standard MRDocCategoryCaseType entity.
// </summary>
// <copyright file= "MRDocCategoryCaseTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MRDocCategoryCaseTypeEntity.
    /// </summary>
    [Serializable]
    public class MRDocCategoryCaseTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MRDocCategoryCaseType"/> class.
        /// </summary>
        public MRDocCategoryCaseTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the CaseTypeCode field.
        /// </summary>
        /// <value>The case type code.</value>
        public String CaseTypeCode
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the DocCategoryCode field.
        /// </summary>
        /// <value>The doc category code.</value>
        public String DocCategoryCode
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the FolderID field.
        /// </summary>
        /// <value>The folder ID.</value>
        public Int64 FolderID
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the FolderLevel field.
        /// </summary>
        /// <value>The folder level.</value>
        public Int32 FolderLevel
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the ParentCategoryCode field.
        /// </summary>
        /// <value>The parent category code.</value>
        public String ParentCategoryCode
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the SeqNo field.
        /// </summary>
        /// <value>The seq no.</value>
        public Int32 SeqNo
        {
            get;set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            MRDocCategoryCaseTypeEntity toCompareWith = obj as MRDocCategoryCaseTypeEntity;
            return toCompareWith == null ? false : ((this.FolderID == toCompareWith.FolderID));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FolderID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}