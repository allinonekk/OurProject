#region Header

/*****************************************************************************************************
* Description : This file represents a standard CWUInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   01/10/2010  		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CWUInfoEntity.cs
// Description: Represents a standard CWUInfo entity.
// </summary>
// <copyright file= "CWUInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for CWUInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class CWUInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CWUInfoEntity"/> class.
        /// </summary>
        public CWUInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the CWUInfoId field.
        /// </summary>
        /// <value>The CWU info id.</value>
        public String CWUInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WindingType field.
        /// </summary>
        /// <value>The type of the winding.</value>
        public WindingType WindingType
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

            CWUInfoEntity toCompareWith = obj as CWUInfoEntity;
            return toCompareWith == null ? false : ((this.CWUInfoId == toCompareWith.CWUInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CWUInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}