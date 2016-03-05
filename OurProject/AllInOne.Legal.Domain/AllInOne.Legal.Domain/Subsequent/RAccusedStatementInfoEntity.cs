#region Header

/*****************************************************************************************************
* Description : This file represents a standard RAccusedStatementInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   24/06/2011                 CJ             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: RAccusedStatementInfoEntity.cs
// Description: Represents a standard RAccusedStatementInfo entity.
// </summary>
// <copyright file= "RAccusedStatementInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for RAccusedStatementInfo.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class RAccusedStatementInfoEntity : AbstractLastModified, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CasePartyId field.
        /// </summary>
        /// <value>The CaseParty id.</value>
        public String CasePartyId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfStatement field.
        /// </summary>
        /// <value>The Date Of Statement.</value>
        public DateTime DateOfStatement
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocId field.
        /// </summary>
        /// <value>The Doc id.</value>
        public String DocId
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

            RAccusedStatementInfoEntity toCompareWith = obj as RAccusedStatementInfoEntity;
            return toCompareWith == null ? false : ((this.DocId == toCompareWith.DocId) && (this.CasePartyId == toCompareWith.CasePartyId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocId.GetHashCode();
            toReturn ^= this.CasePartyId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}