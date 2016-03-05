#region Header

/*****************************************************************************************************
* Description : This file represents a standard MActingInCapacity entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   24/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MActingInCapacityEntity.cs
// Description: Represents a standard MActingInCapacity entity.
// </summary>
// <copyright file= "MActingInCapacityEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MActingInCapacity.
    /// </summary>
    [Serializable]
    public class MActingInCapacityEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MActingInCapacityEntity"/> class.
        /// </summary>
        public MActingInCapacityEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the AICCode field.
        /// </summary>
        /// <value>The AIC code.</value>
        public String AICCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the AICGroupCode field.
        /// </summary>
        /// <value>The AIC group code.</value>
        public String AICGroupCode
        {
            get; set;
        }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            MActingInCapacityEntity toCompareWith = obj as MActingInCapacityEntity;
            return toCompareWith == null ? false : ((this.AICCode == toCompareWith.AICCode));
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
            toReturn ^= this.AICCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}