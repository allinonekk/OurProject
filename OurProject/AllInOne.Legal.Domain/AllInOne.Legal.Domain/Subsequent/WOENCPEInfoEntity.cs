#region Header

/*****************************************************************************************************
* Description : This file represents a standard WOENCPEInfo entity.
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
// File: WOENCPEInfoEntity.cs
// Description: Represents a standard WOENCPEInfo entity.
// </summary>
// <copyright file= "WOENCPEInfoEntity.cs" company="AllInOne Pte Ltd">
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
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'Subsequent.WOENCPEInfoEntity'</summary>
    [Serializable]
    public partial class WOENCPEInfoEntity : AbstractLastModified, ISubsequentEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="WOENCPEInfoEntity"/> class.</summary>
        public WOENCPEInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the AmountClaimed field. </summary>
        public Decimal? AmountClaimed
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ClaimDesc field. </summary>
        public String ClaimDesc
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ClaimObject field. </summary>
        public WOEInfoClaimType ClaimObject
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ClaimRemarks field. </summary>
        public String ClaimRemarks
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CurrencyCode field. </summary>
        public MCurrencyEntity CurrencyCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemClaimed field. </summary>
        public Int32? ItemClaimed
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PropertyClaimed field. </summary>
        public String PropertyClaimed
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

        /// <summary>Gets or sets the WOENCPEInfoId field. </summary>
        public String WOENCPEInfoId
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
            WOENCPEInfoEntity toCompareWith = obj as WOENCPEInfoEntity;
            return toCompareWith == null ? false : ((this.WOENCPEInfoId == toCompareWith.WOENCPEInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WOENCPEInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}