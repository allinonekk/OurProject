#region Header

/*****************************************************************************************************
* Description : This file represents a standard MPartyType entity.
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
// File: MPartyTypeEntity.cs
// Description: Represents a standard MPartyType entity.
// </summary>
// <copyright file= "MPartyTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MPartyTypeEntity.
    /// </summary>
    [Serializable]
    public class MPartyTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MPartyType"/> class.
        /// </summary>
        public MPartyTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the IsInterfaced field.
        /// </summary>
        /// <value>The is interfaced.</value>
        public String IsInterfaced
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the PartyTypeCode field.
        /// </summary>
        /// <value>The party type code.</value>
        public String PartyTypeCode
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
            MPartyTypeEntity toCompareWith = obj as MPartyTypeEntity;
            return toCompareWith == null ? false : ((this.PartyTypeCode == toCompareWith.PartyTypeCode));
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
            toReturn ^= this.PartyTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}