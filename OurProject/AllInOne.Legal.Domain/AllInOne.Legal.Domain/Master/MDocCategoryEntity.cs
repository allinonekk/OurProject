#region Header

/*****************************************************************************************************
* Description : This file represents a standard MDocCategory entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MDocCategoryEntity.cs
// Description: Represents a standard MDocCategory entity.
// </summary>
// <copyright file= "MDocCategoryEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MDocCategory.
    /// </summary>
    [Serializable]
    public class MDocCategoryEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MDocCategory"/> class.
        /// </summary>
        public MDocCategoryEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the DocCategoryCode field.
        /// </summary>
        /// <value>The doc category code.</value>
        public String DocCategoryCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ForSubsequentFiling field.
        /// </summary>
        /// <value>The ForSubsequentFiling.</value>
        public YesNo ForSubsequentFiling
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ParentCategoryCode field.
        /// </summary>
        /// <value>The parent category code.</value>
        public String ParentCategoryCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SeqNo field.
        /// </summary>
        /// <value>The seq no.</value>
        public Int32 SeqNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SortingType field.
        /// </summary>
        /// <value>The SortingType.</value>
        public Int32? SortingType
        {
            get;
            set;
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
            if (obj == null)
            {
                return false;
            }
            MDocCategoryEntity toCompareWith = obj as MDocCategoryEntity;
            return toCompareWith == null ? false : ((this.DocCategoryCode == toCompareWith.DocCategoryCode));
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
            toReturn ^= this.DocCategoryCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}