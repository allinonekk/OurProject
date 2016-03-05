#region Header

/*****************************************************************************************************
 * Description : This file represents a standard RDocLawFirm.
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
// File: RDocLawFirmEntity.cs
// Description: Represents a standard RDocLawFirm.
// </summary>
// <copyright file= "RDocLawFirmEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for RDocLawFirm.
    /// It inherits from <see cref="AbstractDocId"/>
    /// </summary>
    [Serializable]
    public class RDocCounterClaimFiledEntity : AbstractLastModified, IDocumentEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RDocCounterClaimFiledEntity"/> class.
        /// </summary>
        public RDocCounterClaimFiledEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the RDocCounterClaimFiledID field.
        /// </summary>
        /// <value>The RDocCounterClaimFiledID.</value>
        public String RDocCounterClaimFiledID
        {
            get;
            set;
        }

        public String CaseCounterClaimID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <remarks>The ObsInd is <see cref="YesNo"/>.</remarks>
        /// <value>The ObsInd ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubmissionGroupID field.
        /// </summary>
        /// <value>The SubmissionGroupID id.</value>
        public String SubmissionGroupID
        {
            get;
            set;
        }

        public String DocID
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

            RDocCounterClaimFiledEntity toCompareWith = obj as RDocCounterClaimFiledEntity;
            return toCompareWith == null ? false : ((this.RDocCounterClaimFiledID == toCompareWith.RDocCounterClaimFiledID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RDocCounterClaimFiledID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}