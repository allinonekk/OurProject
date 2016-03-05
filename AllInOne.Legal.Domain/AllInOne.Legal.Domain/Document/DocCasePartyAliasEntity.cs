#region Header

/*****************************************************************************************************
 * Description : This file represents a standard DocCasePartyAlias.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 25/09/2010   		      Swaroop             	 	Updated
 *****************************************************************************************************/
// <summary>
// File: DocCasePartyAliasEntity.cs
// Description: Represents a standard DocCasePartyAlias.
// </summary>
// <copyright file= "DocCasePartyAliasEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for DocCasePartyAlias.
    /// It inherits from <see cref="AbstractDocCaseParty"/>
    /// </summary>
    [Serializable]
    public class DocCasePartyAliasEntity : AbstractDocCaseParty, IDocumentEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DocCasePartyAliasEntity"/> class.
        /// </summary>
        public DocCasePartyAliasEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the AliasName field.
        /// </summary>
        /// <value>The name of the alias.</value>
        public String AliasName
        {
            get;
            set;
        }

        // <summary>Gets or sets the ItemNo field. </summary>
        /// <summary>
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RecId field.
        /// </summary>
        /// <value>The rec id.</value>
        public String RecId
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

            DocCasePartyAliasEntity toCompareWith = obj as DocCasePartyAliasEntity;
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