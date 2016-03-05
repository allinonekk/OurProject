#region Header

/*****************************************************************************************************
* Description : This file represents a standard LACDocumentDraft entity.
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
// File: LACDocumentDraftEntity.cs
// Description: Represents a standard LACDocumentDraft entity.
// </summary>
// <copyright file= "LACDocumentDraftEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LAP
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for LACDocumentDraft.
    /// It inherits from <see cref="AbstractCasePartyCaseInfo"/>
    /// </summary>
    [Serializable]
    public class LACDocumentDraftEntity : AbstractCasePartyCaseInfo, ILAPEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the LAC doc detail id.
        /// </summary>
        /// <value>The LAC doc detail id.</value>
        public String LACDocDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LACDocDraftId field.
        /// </summary>
        /// <value>The LAC doc draft id.</value>
        public String LACDocDraftId
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

            LACDocumentDraftEntity toCompareWith = obj as LACDocumentDraftEntity;
            return toCompareWith == null ? false : ((this.LACDocDraftId == toCompareWith.LACDocDraftId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LACDocDraftId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}