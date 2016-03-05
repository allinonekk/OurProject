#region Header

/*****************************************************************************************************
* Description : This file represents a standard MRelief entity.
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
// File: MReliefEntity.cs
// Description: Represents a standard MRelief entity.
// </summary>
// <copyright file= "MReliefEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MReliefEntity.
    /// </summary>
    [Serializable]
    public class MReliefEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MRelief"/> class.
        /// </summary>
        public MReliefEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the ReliefCode field.
        /// </summary>
        /// <value>The relief code.</value>
        public String ReliefCode
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
            MReliefEntity toCompareWith = obj as MReliefEntity;
            return toCompareWith == null ? false : ((this.ReliefCode == toCompareWith.ReliefCode));
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
            toReturn ^= this.ReliefCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}