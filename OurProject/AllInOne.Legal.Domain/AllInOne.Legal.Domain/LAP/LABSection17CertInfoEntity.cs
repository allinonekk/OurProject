#region Header

/*****************************************************************************************************
* Description : This file represents a standard LABSection17CertInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LABSection17CertInfoEntity.cs
// Description: Represents a standard LABSection17CertInfo entity.
// </summary>
// <copyright file= "LABSection17CertInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LAP
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for LABSection17CertInfo.
    /// It inherits from <see cref="AbstractCaseInfoCasePartyDocId"/>
    /// </summary>
    [Serializable]
    public class LABSection17CertInfoEntity : AbstractCaseInfoCasePartyDocId, ILAPEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the IsGAPGAFiled field.
        /// </summary>
        /// <value>The is GAPGA filed.</value>
        public YesNo IsGAPGAFiled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Section17CertId field.
        /// </summary>
        /// <value>The section17 cert id.</value>
        public String Section17CertId
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

            LABSection17CertInfoEntity toCompareWith = obj as LABSection17CertInfoEntity;
            return toCompareWith == null ? false : ((this.Section17CertId == toCompareWith.Section17CertId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.Section17CertId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}