#region Header

/*****************************************************************************************************
* Description : This file represents a standard MDocSecurity entity.
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
// File: MDocSecurityEntity.cs
// Description: Represents a standard MDocSecurity entity.
// </summary>
// <copyright file= "MDocSecurityEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MDocSecurity.
    /// </summary>
    [Serializable]
    public class MDocSecurityEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MDocSecurityEntity"/> class.
        /// </summary>
        public MDocSecurityEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the DocSecurityCode field.
        /// </summary>
        /// <value>The doc security code.</value>
        public String DocSecurityCode
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

            MDocSecurityEntity toCompareWith = obj as MDocSecurityEntity;
            return toCompareWith == null ? false : ((this.DocSecurityCode == toCompareWith.DocSecurityCode));
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
            toReturn ^= this.DocSecurityCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}