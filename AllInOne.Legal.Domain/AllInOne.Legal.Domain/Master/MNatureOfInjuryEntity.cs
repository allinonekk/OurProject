#region Header

/*****************************************************************************************************
* Description : This file represents a standard MNatureOfInjury entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   29/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MNatureOfInjuryEntity.cs
// Description: Represents a standard MNatureOfInjury entity.
// </summary>
// <copyright file= "MNatureOfInjuryEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MNatureOfInjury.
    /// </summary>
    [Serializable]
    public class MNatureOfInjuryEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MNatureOfInjuryEntity"/> class.
        /// </summary>
        public MNatureOfInjuryEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the NOICode field.
        /// </summary>
        /// <value>The NOI code.</value>
        public String NOICode
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

            MNatureOfInjuryEntity toCompareWith = obj as MNatureOfInjuryEntity;
            return toCompareWith == null ? false : ((this.NOICode == toCompareWith.NOICode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NOICode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}