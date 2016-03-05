#region Header

/*****************************************************************************************************
* Description : This file represents a standard MHRGType entity.
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
// File: MHRGTypeEntity.cs
// Description: Represents a standard MHRGTypeEntity entity.
// </summary>
// <copyright file= "MHRGTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MHRGTypeEntity.
    /// </summary>
    [Serializable]
    public class MIconItemEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MIconItem"/> class.
        /// </summary>
        public MIconItemEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the IconCode field.
        /// </summary>
        /// <value>The icon code.</value>
        public String IconCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Location field.
        /// </summary>
        /// <value>The location.</value>
        public String Location
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Type field.
        /// </summary>
        /// <value>The type.</value>
        public String Type
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
            MIconItemEntity toCompareWith = obj as MIconItemEntity;
            return toCompareWith == null ? false : ((this.IconCode == toCompareWith.IconCode));
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
            toReturn ^= this.IconCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}