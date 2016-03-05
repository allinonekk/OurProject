#region Header

/*****************************************************************************************************
* Description : This file represents a standard MCriminalClaimantType entity.
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
// File: MCriminalClaimantTypeEntity.cs
// Description: Represents a standard MCriminalClaimantType entity.
// </summary>
// <copyright file= "MCriminalClaimantTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.MCriminalClaimantType'</summary>
    public class MCriminalClaimantTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MCriminalClaimantType"/> class.</summary>
        public MCriminalClaimantTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the CriminalClaimantTypeCode field. </summary>
        public String CriminalClaimantTypeCode
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
            MCriminalClaimantTypeEntity toCompareWith = obj as MCriminalClaimantTypeEntity;
            return toCompareWith == null ? false : ((this.CriminalClaimantTypeCode == toCompareWith.CriminalClaimantTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CriminalClaimantTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}