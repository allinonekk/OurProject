#region Header

/*****************************************************************************************************
* Description : This file represents a standard MNOC entity.
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
// File: MNOCEntity.cs
// Description: Represents a standard MNOCEntity entity.
// </summary>
// <copyright file= "MNOCEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MNOCEntity.
    /// </summary>
    [Serializable]
    public class MNOCEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MNOC"/> class.
        /// </summary>
        public MNOCEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the ClaimLevel field.
        /// </summary>
        /// <value>The claim level.</value>
        public Int32 ClaimLevel
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

        /// <summary>
        /// Gets or sets the NOCCode field.
        /// </summary>
        /// <value>The NOC code.</value>
        public String NOCCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ParentClaimTypeCode field.
        /// </summary>
        /// <value>The parent claim type code.</value>
        public String ParentClaimTypeCode
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
            MNOCEntity toCompareWith = obj as MNOCEntity;
            return toCompareWith == null ? false : ((this.NOCCode == toCompareWith.NOCCode));
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
            toReturn ^= this.NOCCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}