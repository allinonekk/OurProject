#region Header

/*****************************************************************************************************
* Description : This file represents a standard WOEInfo entity.
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
// File: WOEInfoEntity.cs
// Description: Represents a standard WOEInfo entity.
// </summary>
// <copyright file= "WOEInfoEntity.cs" company="AllInOne Pte Ltd">
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

    /// <summary>Class which represents the entity 'Subsequent.WOEInfoEntity'</summary>
    [Serializable]
    public partial class WOEInfoEntity : AbstractLastModified, ISubsequentEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="WOEInfoEntity"/> class.</summary>
        public WOEInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the Interest field. </summary>
        public Decimal? Interest
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsAuthorisedBailiff field. </summary>
        public YesNo IsAuthorisedBailiff
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsExecOutOffHour field. </summary>
        public YesNo IsExecOutOffHour
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsWritSeizure field. </summary>
        public YesNo IsWritSeizure
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

        /// <summary>Gets or sets the WOEInfoId field. </summary>
        public String WOEInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WritAmount field. </summary>
        public Decimal? WritAmount
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WritCost field. </summary>
        public Decimal? WritCost
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
            WOEInfoEntity toCompareWith = obj as WOEInfoEntity;
            return toCompareWith == null ? false : ((this.WOEInfoId == toCompareWith.WOEInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WOEInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}