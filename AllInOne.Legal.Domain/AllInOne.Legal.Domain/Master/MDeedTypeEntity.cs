#region Header

/*****************************************************************************************************
* Description : This file represents a standard MDeedType entity.
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
// File: MDeedTypeEntity.cs
// Description: Represents a standard MDeedType entity.
// </summary>
// <copyright file= "MDeedTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MDeedType.
    /// </summary>
    [Serializable]
    public class MDeedTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MDeedType"/> class.
        /// </summary>
        public MDeedTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the ComDocGroupInd field.
        /// </summary>
        /// <value>The COM doc group ind.</value>
        public String ComDocGroupInd
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the DeedTypeCode field.
        /// </summary>
        /// <value>The deed type code.</value>
        public String DeedTypeCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SeqNo field.
        /// </summary>
        /// <value>The seq no.</value>
        public Int32? SeqNo
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
            MDeedTypeEntity toCompareWith = obj as MDeedTypeEntity;
            return toCompareWith == null ? false : ((this.DeedTypeCode == toCompareWith.DeedTypeCode));
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
            toReturn ^= this.DeedTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}