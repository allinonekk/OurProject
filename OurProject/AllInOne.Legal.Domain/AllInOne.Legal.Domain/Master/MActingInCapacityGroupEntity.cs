#region Header

/*****************************************************************************************************
* Description : This file represents a standard MActingInCapacityGroup entity.
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
// File: MActingInCapacityGroupEntity.cs
// Description: Represents a standard MActingInCapacityGroup entity.
// </summary>
// <copyright file= "MActingInCapacityGroupEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MActingInCapacityGroup.
    /// </summary>
    [Serializable]
    public class MActingInCapacityGroupEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MActingInCapacityGroup"/> class.
        /// </summary>
        public MActingInCapacityGroupEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

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
            MActingInCapacityGroupEntity toCompareWith = obj as MActingInCapacityGroupEntity;
            return toCompareWith == null ? false : ((this.AICGroupCode == toCompareWith.AICGroupCode));
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
            toReturn ^= this.AICGroupCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}