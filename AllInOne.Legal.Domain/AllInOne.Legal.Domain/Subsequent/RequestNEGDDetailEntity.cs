#region Header

/*****************************************************************************************************
 * Description : This file represents a standard RequestDocDetailEntity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 23/01/2011   		      Nithin             	 	Created
 *****************************************************************************************************/
// <summary>
// File: CDRInfoEntity.cs
// Description: Represents a standard RequestDocDetailEntity.
// </summary>
// <copyright file= "RequestDocDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for RequestNEGDDetailEntity.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class RequestNEGDDetailEntity : AbstractSubmissionGroup, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Subsequent.RequestDocDetail.MFilingFee - Master.MFilingFee.RequestDocDetails (m:1)'
        /// </summary>
        /// <value>The M filing fee.</value>
        public YesNo ApprovedStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BilledDate field.
        /// </summary>
        /// <value>The billed date.</value>
        public String DocumentType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsInterfaced field.
        /// </summary>
        /// <value>The is interfaced.</value>
        public String HeardBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocId field.
        /// </summary>
        /// <value>The doc id.</value>
        public DateTime? HearingDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AmtRequested field.
        /// </summary>
        /// <value>The amt requested.</value>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AmtApproved field.
        /// </summary>
        /// <value>The amt approved.</value>
        public String RequestNEGDDetailId
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
            RequestNEGDDetailEntity toCompareWith = obj as RequestNEGDDetailEntity;
            return toCompareWith == null ? false : ((this.RequestNEGDDetailId == toCompareWith.RequestNEGDDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RequestNEGDDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}