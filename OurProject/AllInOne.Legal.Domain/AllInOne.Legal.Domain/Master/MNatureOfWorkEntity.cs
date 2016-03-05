#region Header

/*****************************************************************************************************
* Description : This file represents a standard MNatureOfWork entity.
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
// File: MNatureOfWorkEntity.cs
// Description: Represents a standard MNatureOfWorkEntity entity.
// </summary>
// <copyright file= "MNatureOfWorkEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MNatureOfWorkEntity.
    /// </summary>
    [Serializable]
    public class MNatureOfWorkEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MNatureOfWork"/> class.
        /// </summary>
        public MNatureOfWorkEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the BillNatureCode field.
        /// </summary>
        /// <value>The bill nature code.</value>
        public String BillNatureCode
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the IsInterfaced field.
        /// </summary>
        /// <value>The is interfaced.</value>
        public String IsInterfaced
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the NOWCode field.
        /// </summary>
        /// <value>The NOW code.</value>
        public String NOWCode
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
            MNatureOfWorkEntity toCompareWith = obj as MNatureOfWorkEntity;
            return toCompareWith == null ? false : ((this.NOWCode == toCompareWith.NOWCode));
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
            toReturn ^= this.NOWCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}