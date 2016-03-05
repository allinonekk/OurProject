#region Header

/*****************************************************************************************************
* Description : This file represents a standard MNAACategory entity.
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
// File: MNAACategoryEntity.cs
// Description: Represents a standard MNAACategoryEntity entity.
// </summary>
// <copyright file= "MNAACategoryEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MNAACategoryEntity.
    /// </summary>
    [Serializable]
    public class MNAACategoryEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Fields

        private Int32 _categoryID;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MNAACategory"/> class.
        /// </summary>
        public MNAACategoryEntity()
            : base()
        {
            _categoryID = default(System.Int32);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the CategoryID field.
        /// </summary>
        /// <value>The category ID.</value>
        public Int32 CategoryID
        {
            get { return _categoryID; }
        }

        /// <summary>
        /// Gets or sets the CategoryName field.
        /// </summary>
        /// <value>The name of the category.</value>
        public String CategoryName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ShortDescription field.
        /// </summary>
        /// <value>The short description.</value>
        public String ShortDescription
        {
            get; set;
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
            MNAACategoryEntity toCompareWith = obj as MNAACategoryEntity;
            return toCompareWith == null ? false : ((this.CategoryID == toCompareWith.CategoryID));
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
            toReturn ^= this.CategoryID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}