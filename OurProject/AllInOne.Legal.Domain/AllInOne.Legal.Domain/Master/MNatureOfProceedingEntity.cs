#region Header

/*****************************************************************************************************
* Description : This file represents a standard MNatureOfProceeding entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   28/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MNatureOfProceedingEntity.cs
// Description: Represents a standard MNatureOfProceeding entity.
// </summary>
// <copyright file= "MNatureOfProceedingEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MNatureOfProceeding.
    /// </summary>
    [Serializable]
    public class MNatureOfProceedingEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MNatureOfProceedingEntity"/> class.
        /// </summary>
        public MNatureOfProceedingEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the NOPCode field. </summary>
        public String NOPCode
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
            if (obj == null)
            {
                return false;
            }

            MNatureOfProceedingEntity toCompareWith = obj as MNatureOfProceedingEntity;
            return toCompareWith == null ? false : ((this.NOPCode == toCompareWith.NOPCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NOPCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}