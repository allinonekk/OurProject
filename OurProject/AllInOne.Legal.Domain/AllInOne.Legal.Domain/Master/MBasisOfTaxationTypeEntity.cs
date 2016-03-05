#region Header

/*****************************************************************************************************
* Description : This file represents a standard MBasisOfTaxationType entity.
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
// File: MBasisOfTaxationTypeEntity.cs
// Description: Represents a standard MBasisOfTaxationType entity.
// </summary>
// <copyright file= "MBasisOfTaxationTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MBasisOfTaxationType.
    /// </summary>
    [Serializable]
    public class MBasisOfTaxationTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MBasisOfTaxationType"/> class.
        /// </summary>
        public MBasisOfTaxationTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the BOTTypeCode field.
        /// </summary>
        /// <value>The BOT type code.</value>
        public String BOTTypeCode
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
            if (obj == null)
            {
                return false;
            }
            MBasisOfTaxationTypeEntity toCompareWith = obj as MBasisOfTaxationTypeEntity;
            return toCompareWith == null ? false : ((this.BOTTypeCode == toCompareWith.BOTTypeCode));
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
            toReturn ^= this.BOTTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}