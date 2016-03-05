#region Header

/*****************************************************************************************************
* Description : This file represents a standard MRoutingType entity.
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
// File: MRoutingTypeEntity.cs
// Description: Represents a standard MRoutingType entity.
// </summary>
// <copyright file= "MRoutingTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MRoutingTypeEntity.
    /// </summary>
    [Serializable]
    public class MRoutingTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Fields

        private Int32 routingTypeId;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MRoutingType"/> class.
        /// </summary>
        public MRoutingTypeEntity()
            : base()
        {
            routingTypeId= default(System.Int32);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the RoutingTypeID field.
        /// </summary>
        /// <value>The routing type id.</value>
        public Int32 RoutingTypeId
        {
            get { return routingTypeId; }
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
            MRoutingTypeEntity toCompareWith = obj as MRoutingTypeEntity;
            return toCompareWith == null ? false : ((this.RoutingTypeId == toCompareWith.RoutingTypeId));
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
            toReturn ^= this.RoutingTypeId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}