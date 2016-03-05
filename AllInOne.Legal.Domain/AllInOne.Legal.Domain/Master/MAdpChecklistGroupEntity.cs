#region Header

/*****************************************************************************************************
* Description : This file represents a standard MAdpChecklistGroupEntity entity.
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
// File: MAdpChecklistGroupEntity.cs
// Description: Represents a standard MAdpChecklistGroupEntity entity.
// </summary>
// <copyright file= "MAdpChecklistGroupEntityEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MAdpChecklistGroupEntity.
    /// </summary>
    [Serializable]
    public class MAdpChecklistGroupEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MAdpChecklistGroup"/> class.
        /// </summary>
        public MAdpChecklistGroupEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the AdpCLGroupCode field.
        /// </summary>
        /// <value>The adp CL group code.</value>
        public String AdpCLGroupCode
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
            MAdpChecklistGroupEntity toCompareWith = obj as MAdpChecklistGroupEntity;
            return toCompareWith == null ? false : ((this.AdpCLGroupCode == toCompareWith.AdpCLGroupCode));
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
            toReturn ^= this.AdpCLGroupCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}