#region Header

/*****************************************************************************************************
* Description : This file represents a standard MAdpChecklistItemEntity entity.
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
// File: MAdpChecklistItemEntity.cs
// Description: Represents a standard MAdpChecklistItem entity.
// </summary>
// <copyright file= "MAdpChecklistItemEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MAdpChecklistItem.
    /// </summary>
    [Serializable]
    public class MAdpChecklistItemEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MAdpChecklistItemEntity"/> class.
        /// </summary>
        public MAdpChecklistItemEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the AdpCLItemCode field.
        /// </summary>
        /// <value>The adp CL item code.</value>
        public String AdpCLItemCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The item no.</value>
        public Int32 ItemNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the M adp checklist group entity.
        /// </summary>
        /// <value>The M adp checklist group entity.</value>
        public MAdpChecklistGroupEntity MAdpChecklistGroupEntity
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
            MAdpChecklistItemEntity toCompareWith = obj as MAdpChecklistItemEntity;
            return toCompareWith == null ? false : ((this.AdpCLItemCode == toCompareWith.AdpCLItemCode));
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
            toReturn ^= this.AdpCLItemCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}