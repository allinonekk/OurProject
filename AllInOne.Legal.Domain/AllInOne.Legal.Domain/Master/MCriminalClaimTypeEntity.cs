#region Header

/*****************************************************************************************************
* Description : This file represents a standard MCriminalClaimType entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   29/03/2011   		      Chun Jie             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MCriminalClaimTypeEntity.cs
// Description: Represents a standard MCriminalClaimType entity.
// </summary>
// <copyright file= "MCriminalClaimTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MCriminalClaimTypeEntity'</summary>
    public class MCriminalClaimTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MCriminalClaimType"/> class.
        /// </summary>
        public MCriminalClaimTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the CriminalClaimTypeCode field. </summary>
        public String CriminalClaimTypeCode
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            MCriminalClaimTypeEntity toCompareWith = obj as MCriminalClaimTypeEntity;
            return toCompareWith == null ? false : ((this.CriminalClaimTypeCode == toCompareWith.CriminalClaimTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CriminalClaimTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}