#region Header

/*****************************************************************************************************
 * Description : This file represents a standard PartyAmendmentEntity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 22/01/2011   		      Nithin             	 	Created
 *****************************************************************************************************/
// <summary>
// File: CDRInfoEntity.cs
// Description: Represents a standard CDRInfo.
// </summary>
// <copyright file= "PartyAmendmentEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for PartyAmendment.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class PartyAmendmentEntity : AbstractLastModified, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AmendmentId field.
        /// </summary>
        /// <value>The amendment id.</value>
        public String AmendmentId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AmendmentMode field.
        /// </summary>
        /// <value>The amendment mode.</value>
        public ModeOfAmendment AmendmentMode
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.PartyAmendment.CaseParty - Case.CaseParty.PartyAmendments (m:1)'
        /// </summary>
        /// <value>The case party id.</value>
        public String CasePartyId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.PartyAmendment.DocCaseParty - Document.DocCaseParty.PartyAmendments (m:1)'
        /// </summary>
        /// <value>The DCP id.</value>
        public String DCPId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.PartyAmendment.DocumentInfo - Document.DocumentInfo.PartyAmendments (m:1)'
        /// </summary>
        /// <value>The doc id.</value>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the InSupport field.
        /// </summary>
        /// <value>The in support.</value>
        public AmendmentInSupport InSupport
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PerformedAt field.
        /// </summary>
        /// <value>The performed at.</value>
        public AmendmentPerformedAt PerformedAt
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Status field.
        /// </summary>
        /// <value>The status.</value>
        public AmendmentStatus Status
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
            PartyAmendmentEntity toCompareWith = obj as PartyAmendmentEntity;
            return toCompareWith == null ? false : ((this.AmendmentId == toCompareWith.AmendmentId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AmendmentId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}