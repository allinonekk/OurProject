#region Header

/*****************************************************************************************************
* Description : This file represents a standard CaseOriginatingCase entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   16/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: CaseOriginatingCaseEntity.cs
// Description: Represents a standard CaseOriginatingCase entity.
// </summary>
// <copyright file= "CaseOriginatingCaseEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for CaseOriginatingCase.
    /// It inherits from <see cref="AbstractRecIdCaseInfo"/>
    /// </summary>
    [Serializable]
    public class CaseOriginatingCaseEntity : AbstractRecIdCaseInfo, ICaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CourtId field.
        /// </summary>
        /// <value>The court id.</value>
        public MCourtTypeEntity CourtId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the OriginatingCaseInfoId field.
        /// </summary>
        /// <value>The originating case info id.</value>
        public String OriginatingCaseInfoId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the OriginatingCaseName field.
        /// </summary>
        /// <value>The name of the originating case.</value>
        public String OriginatingCaseName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OriginatingCaseNo field.
        /// </summary>
        /// <value>The originating case no.</value>
        public String OriginatingCaseNo
        {
            get; set;
        }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            CaseOriginatingCaseEntity toCompareWith = obj as CaseOriginatingCaseEntity;
            return toCompareWith == null ? false : ((this.RecId == toCompareWith.RecId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RecId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}