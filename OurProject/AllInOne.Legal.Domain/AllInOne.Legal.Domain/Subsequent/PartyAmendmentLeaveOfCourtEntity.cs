#region Header

/*****************************************************************************************************
 * Description : This file represents a standard PartyAmendmentLeaveOfCourtEntity.
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
// Description: Represents a standard PartyAmendmentLeaveOfCourt.
// </summary>
// <copyright file= "PartyAmendmentLeaveOfCourtEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for PartyAmendmentLeaveOfCourtEntity.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class PartyAmendmentLeaveOfCourtEntity : AbstractLastModified, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AdditionalDetails field.
        /// </summary>
        /// <value>The additional details.</value>
        public String AdditionalDetails
        {
            get;
            set;
        }

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
        /// Represents the navigator which is mapped onto the association 'Case.PartyAmendmentLeaveOfCourt.CaseInfo - Case.CaseInfo.PartyAmendmentLeaveOfCourts (m:1)'
        /// </summary>
        /// <value>The case info id.</value>
        public String CaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfOrder field.
        /// </summary>
        /// <value>The date of order.</value>
        public DateTime? DateOfOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The item no.</value>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Case.PartyAmendmentLeaveOfCourt.MDesignation - Master.MDesignation.PartyAmendmentLeaveOfCourts (m:1)'
        /// </summary>
        /// <value>The M designation.</value>
        public MDesignationEntity MDesignation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OrderCoram field.
        /// </summary>
        /// <value>The order coram.</value>
        public String OrderCoram
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OrderNumber field.
        /// </summary>
        /// <value>The order number.</value>
        public String OrderNumber
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
            PartyAmendmentLeaveOfCourtEntity toCompareWith = obj as PartyAmendmentLeaveOfCourtEntity;
            return toCompareWith == null ? false : ((this.AmendmentId == toCompareWith.AmendmentId) && (this.ItemNo == toCompareWith.ItemNo));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AmendmentId.GetHashCode();
            toReturn ^= this.ItemNo.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}