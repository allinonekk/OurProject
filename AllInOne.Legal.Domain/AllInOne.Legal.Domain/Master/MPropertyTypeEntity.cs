#region Header

/*****************************************************************************************************
* Description : This file represents a standard MPropertyType entity.
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
// File: MPropertyTypeEntity.cs
// Description: Represents a standard MPropertyType entity.
// </summary>
// <copyright file= "MPropertyTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MPropertyTypeEntity.
    /// </summary>
    [Serializable]
    public class MPropertyTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MPropertyType"/> class.</summary>
        public MPropertyTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the PropertyInd field.
        /// </summary>
        /// <value>The property ind.</value>
        public String PropertyInd
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the PropertyTypeCode field.
        /// </summary>
        /// <value>The property type code.</value>
        public String PropertyTypeCode
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
            MPropertyTypeEntity toCompareWith = obj as MPropertyTypeEntity;
            return toCompareWith == null ? false : ((this.PropertyTypeCode == toCompareWith.PropertyTypeCode));
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
            toReturn ^= this.PropertyTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}