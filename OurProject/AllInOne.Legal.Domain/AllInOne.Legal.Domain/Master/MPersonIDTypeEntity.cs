#region Header

/*****************************************************************************************************
* Description : This file represents a standard MPersonIDType entity.
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
// File: MPersonIDTypeEntity.cs
// Description: Represents a standard MPersonIDType entity.
// </summary>
// <copyright file= "MPersonIDTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MPersonIDTypeEntity.
    /// </summary>
    [Serializable]
    public class MPersonIDTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MPersonIDType"/> class.
        /// </summary>
        public MPersonIDTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the EntityTypeCode field.
        /// </summary>
        /// <value>The entity type code.</value>
        //public String EntityTypeCode
        //{
        //    get; set;
        //}
        /// <summary>
        /// Gets or sets the IDTypeCode field.
        /// </summary>
        /// <value>The ID type code.</value>
        public String IDTypeCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the UIDescription field.
        /// </summary>
        /// <value>The UI description.</value>
        public String UIDescription
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
            MPersonIDTypeEntity toCompareWith = obj as MPersonIDTypeEntity;
            return toCompareWith == null ? false : ((this.IDTypeCode == toCompareWith.IDTypeCode));
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
            toReturn ^= this.IDTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}