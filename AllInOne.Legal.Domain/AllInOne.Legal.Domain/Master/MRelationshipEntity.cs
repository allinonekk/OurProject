#region Header

/*****************************************************************************************************
* Description : This file represents a standard MRelationship entity.
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
// File: MRelationshipEntity.cs
// Description: Represents a standard MRelationship entity.
// </summary>
// <copyright file= "MRelationshipEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MRelationshipEntity.
    /// </summary>
    [Serializable]
    public class MRelationshipEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MRelationship"/> class.
        /// </summary>
        public MRelationshipEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the Category field.
        /// </summary>
        /// <value>The category.</value>
        public String Category
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the FrequencyInd field.
        /// </summary>
        /// <value>The frequency ind.</value>
        public Int32? FrequencyInd
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the RelationshipCode field.
        /// </summary>
        /// <value>The relationship code.</value>
        public String RelationshipCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the TypeInd field.
        /// </summary>
        /// <value>The type ind.</value>
        public String TypeInd
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
            MRelationshipEntity toCompareWith = obj as MRelationshipEntity;
            return toCompareWith == null ? false : ((this.RelationshipCode == toCompareWith.RelationshipCode));
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
            toReturn ^= this.RelationshipCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}