#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for RelatedProceeding.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   22/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: RelatedProceedingEntity.cs
// Description: Represents a standard domain entity for DivorceInfo.
// </summary>
// <copyright file= "RelatedProceedingEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for RelatedProceeding.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class RelatedProceedingEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CaseNo field.
        /// </summary>
        /// <value>The case no.</value>
        public String CaseNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateOfOrder field.
        /// </summary>
        /// <value>The Date Of Order.</value>
        public DateTime? DateOfOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DetailsOfOrder field.
        /// </summary>
        /// <value>The Details Of Order.</value>
        public String DetailsOfOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Divorce.RelatedProceeding.Country - Master.MCountry.RelatedProceedings (m:1)'
        /// </summary>
        /// <value>The country.</value>
        public MCountryEntity MCountry
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NOPCode field.
        /// </summary>
        /// <value>The NatureOfProceeding.</value>
        public MNatureOfProceedingEntity NatureOfProceeding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OtherProceedingInfo field.
        /// </summary>
        /// <value>The other proceeding info.</value>
        public String OtherProceedingInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RelatedCaseId field. It's the primary key.
        /// </summary>
        /// <value>The related case id.</value>
        public String RelatedCaseId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the StatusOfProceedings field. 
        /// </summary>
        /// <value>The Status Of Proceedings.</value>
        public String StatusOfProceedings
        {
            get;
            set;
        }

        public DateTime? DateOfApplication
        {
            get;
            set;
        }

        public string IsPlaintiffBankrupt { get; set; }

        public string PlaintiffBankruptDtls  { get; set; }

        public string PendingBankruptDtls  { get; set; }


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

            RelatedProceedingEntity toCompareWith = obj as RelatedProceedingEntity;
            return toCompareWith == null ? false : ((this.RelatedCaseId == toCompareWith.RelatedCaseId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RelatedCaseId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}