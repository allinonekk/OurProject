#region Header

/*****************************************************************************************************
 * Description : This file represents a standard RDocCaseParty.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 04/10/2010   		      Swaroop             	 	Updated
 *****************************************************************************************************/
// <summary>
// File: RDocCasePartyEntity.cs
// Description: Represents a standard RDocCaseParty.
// </summary>
// <copyright file= "RDocCasePartyEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for RDocCaseParty.
    /// It inherits from <see cref="AbstractDocCaseParty"/>
    /// </summary>
    [Serializable]
    public class RDocCasePartyEntity : AbstractDocCaseParty, IDocumentEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RDocCasePartyEntity"/> class.
        /// </summary>
        public RDocCasePartyEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the DocId field.
        /// </summary>
        /// <value>The doc id.</value>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RDCPId field.
        /// </summary>
        /// <value>The RDCP id.</value>
        public String RDCPId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the UpdateInd field.
        /// </summary>
        /// <value>The update ind.</value>
        public DocCasePartyUpdateType UpdateInd
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

            RDocCasePartyEntity toCompareWith = obj as RDocCasePartyEntity;
            return toCompareWith == null ? false : ((this.RDCPId == toCompareWith.RDCPId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RDCPId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}