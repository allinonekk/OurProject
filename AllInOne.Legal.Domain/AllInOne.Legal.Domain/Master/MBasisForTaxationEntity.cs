#region Header

/*****************************************************************************************************
* Description : This file represents a standard MBasisForTaxation entity.
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
// File: MBasisForTaxationEntity.cs
// Description: Represents a standard MBasisForTaxation entity.
// </summary>
// <copyright file= "MBasisForTaxationEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MBasisForTaxation.
    /// </summary>
    [Serializable]
    public class MBasisForTaxationEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MBasisForTaxation"/> class.
        /// </summary>
        public MBasisForTaxationEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the BFTCode field.
        /// </summary>
        /// <value>The BFT code.</value>
        public String BFTCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the DocCode field.
        /// </summary>
        /// <value>The doc code.</value>
        public String DocCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the IsInterfaced field.
        /// </summary>
        /// <value>The is interfaced.</value>
        public String IsInterfaced
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
            MBasisForTaxationEntity toCompareWith = obj as MBasisForTaxationEntity;
            return toCompareWith == null ? false : ((this.BFTCode == toCompareWith.BFTCode) && (this.DocCode == toCompareWith.DocCode));
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
            toReturn ^= this.BFTCode.GetHashCode();
            toReturn ^= this.DocCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}