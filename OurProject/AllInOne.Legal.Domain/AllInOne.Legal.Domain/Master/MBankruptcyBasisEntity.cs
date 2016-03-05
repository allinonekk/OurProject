#region Header

/*****************************************************************************************************
* Description : This file represents a standard MBankruptcyBasis entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   16/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MBankruptcyBasisEntity.cs
// Description: Represents a standard MBankruptcyBasis entity.
// </summary>
// <copyright file= "MBankruptcyBasisEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MBankruptcyBasis.
    /// </summary>
    [Serializable]
    public class MBankruptcyBasisEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MBankruptcyBasisEntity"/> class.
        /// </summary>
        public MBankruptcyBasisEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the BBCode field.
        /// </summary>
        /// <value>The BB code.</value>
        public String BBCode
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
            MBankruptcyBasisEntity toCompareWith = obj as MBankruptcyBasisEntity;
            return toCompareWith == null ? false : ((this.BBCode == toCompareWith.BBCode));
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
            toReturn ^= this.BBCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}