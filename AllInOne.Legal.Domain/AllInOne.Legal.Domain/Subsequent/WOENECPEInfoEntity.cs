#region Header

/*****************************************************************************************************
* Description : This file represents a standard WOENECPEInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   27/06/2011                 CJ             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: WOENECPEInfoEntity.cs
// Description: Represents a standard WOENECPEInfo entity.
// </summary>
// <copyright file= "WOENECPEInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Subsequent.WOENECPEInfoEntity'</summary>
    [Serializable]
    public partial class WOENECPEInfoEntity : AbstractLastModified, ISubsequentEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="WOENECPEInfoEntity"/> class.</summary>
        public WOENECPEInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the ClaimAdmitStatus field. </summary>
        public YesNo ClaimAdmitStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ClaimantPartyId field. </summary>
        public String ClaimantPartyId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ClaimStatus field. </summary>
        public WOEInfoClaimStatus ClaimStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DocId field. </summary>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsInterpleaderFiled field. </summary>
        public YesNo IsInterpleaderFiled
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public String SubmissionGroupId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WOENECPEInfoId field. </summary>
        public String WOENECPEInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the claimant DCPID.
        /// </summary>
        /// <value>The claimant DCPID.</value>
        public string ClaimantDCPID { get; set; }

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
            WOENECPEInfoEntity toCompareWith = obj as WOENECPEInfoEntity;
            return toCompareWith == null ? false : ((this.WOENECPEInfoId == toCompareWith.WOENECPEInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WOENECPEInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}