#region Header

/*****************************************************************************************************
* Description : This file represents a standard SubCaseInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   07/09/2010   		      Swaroop             	 	Created
*   04/10/2010   		      Swaroop             	 	Added more properties
*****************************************************************************************************/
// <summary>
// File: SubCaseInfoEntity.cs
// Description: Represents a standard SubCaseInfo entity.
// </summary>
// <copyright file= "SubCaseInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCase
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for SubCaseInfo.
    /// It inherits from <see cref="AbstractSubCaseInfo"/>
    /// </summary>
    [Serializable]
    public class SubCaseInfoEntity : AbstractSubCaseInfo, ISubCaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the sub case status code.
        /// </summary>
        /// <value>The sub case status code.</value>
        public MCaseStatusEntity MCaseStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseType field.
        /// </summary>
        /// <value>The type of the sub case.</value>
        public MCaseTypeEntity MSubCaseType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseNo field.
        /// </summary>
        /// <value>The sub case no.</value>
        public String SubCaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseSerialNo field.
        /// </summary>
        /// <value>The sub case serial no.</value>
        public Decimal? SubCaseSerialNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the sub case status date.
        /// </summary>
        /// <value>The sub case status date.</value>
        public DateTime? SubCaseStatusDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseYear field.
        /// </summary>
        /// <value>The sub case year.</value>
        public Decimal? SubCaseYear
        {
            get;
            set;
        }

        public DateTime? HideDocAccessTillDate
        {
            get;
            set;
        }

        public string SubCaseFeeForumID { get; set; }

        public decimal? SubCaseFeeTierType { get; set; }

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

            SubCaseInfoEntity toCompareWith = obj as SubCaseInfoEntity;
            return toCompareWith == null ? false : ((this.SubCaseInfoId == toCompareWith.SubCaseInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SubCaseInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}