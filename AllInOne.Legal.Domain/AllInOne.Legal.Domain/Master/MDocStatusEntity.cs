﻿#region Header

/*****************************************************************************************************
* Description : This file represents a standard MDocStatus entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   14/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MDocStatusEntity.cs
// Description: Represents a standard MDocStatus entity.
// </summary>
// <copyright file= "MDocStatusEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MDocStatus.
    /// </summary>
    [Serializable]
    public class MDocStatusEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MDocStatusEntity"/> class.
        /// </summary>
        public MDocStatusEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the DocStatus field.
        /// </summary>
        /// <value>The doc status.</value>
        public String DocStatus
        {
            get;
            set;
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

            MDocStatusEntity toCompareWith = obj as MDocStatusEntity;
            return toCompareWith == null ? false : ((this.DocStatus == toCompareWith.DocStatus));
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
            toReturn ^= this.DocStatus.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}