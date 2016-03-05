#region Header

/*****************************************************************************************************
* Description : This file represents a standard MBodyPart entity.
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
// File: MBodyPartEntity.cs
// Description: Represents a standard MBodyPart entity.
// </summary>
// <copyright file= "MBodyPartEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MBodyPart.
    /// </summary>
    [Serializable]
    public class MBodyPartEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MBodyPartEntity"/> class.
        /// </summary>
        public MBodyPartEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the BPCode field.
        /// </summary>
        /// <value>The BP code.</value>
        public String BPCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the BPType field.
        /// </summary>
        /// <value>The type of the BP.</value>
        public String BPType
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

            MBodyPartEntity toCompareWith = obj as MBodyPartEntity;
            return toCompareWith == null ? false : ((this.BPCode == toCompareWith.BPCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BPCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}