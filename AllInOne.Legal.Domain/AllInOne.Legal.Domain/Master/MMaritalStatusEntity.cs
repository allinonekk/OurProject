#region Header

/*****************************************************************************************************
* Description : This file represents a standard MMaritalStatus entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   26/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MMaritalStatusEntity.cs
// Description: Represents a standard MMaritalStatusEntity entity.
// </summary>
// <copyright file= "MMaritalStatusEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MMaritalStatusEntity.
    /// </summary>
    [Serializable]
    public class MMaritalStatusEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MMaritalStatus"/> class.
        /// </summary>
        public MMaritalStatusEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the IsProbateInd field.
        /// </summary>
        /// <value>The is probate ind.</value>
        public String IsProbateInd
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the MaritalStatusCode field.
        /// </summary>
        /// <value>The marital status code.</value>
        public String MaritalStatusCode
        {
            get;set;
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
            MMaritalStatusEntity toCompareWith = obj as MMaritalStatusEntity;
            return toCompareWith == null ? false : ((this.MaritalStatusCode == toCompareWith.MaritalStatusCode));
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
            toReturn ^= this.MaritalStatusCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}