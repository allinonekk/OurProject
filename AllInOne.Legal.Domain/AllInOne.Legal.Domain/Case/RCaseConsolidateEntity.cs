#region Header

/*****************************************************************************************************
 * Description : This file represents a standard RCaseConsolidate.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 17/10/2012   		      Nithin             	 	Created
 *****************************************************************************************************/
// <summary>
// File: RCaseConsolidateEntity.cs
// Description: Represents a standard RCaseConsolidate.
// </summary>
// <copyright file= "RCaseConsolidateEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for RCaseLinked.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class RCaseConsolidateEntity : AbstractLastModified, ICaseEntity
    {
        #region Properties

        /// <summary>Gets or sets the LinkGroupId field. </summary>
        public string CaseInfoID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LinkedDate field. </summary>
        public string ConCaseInfoID
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LinkedDate field. </summary>
        public DateTime? ConsolidateDate
        {
            get;
            set;
        }

        public YesNo ObsInd
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
            if (obj == null)
            {
                return false;
            }

            RCaseConsolidateEntity toCompareWith = obj as RCaseConsolidateEntity;
            return toCompareWith == null ? false : ((this.CaseInfoID == toCompareWith.CaseInfoID) && (this.ConCaseInfoID == toCompareWith.ConCaseInfoID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseInfoID.GetHashCode();
            toReturn ^= this.ConCaseInfoID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}