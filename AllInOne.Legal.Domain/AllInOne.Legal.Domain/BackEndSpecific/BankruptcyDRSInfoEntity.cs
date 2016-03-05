#region Header

/*****************************************************************************************************
* Description : This file represents a standard BankruptcyInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   16/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: BankruptcyInfoEntity.cs
// Description: Represents a standard BankruptcyInfo entity.
// </summary>
// <copyright file= "BankruptcyInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for BankruptcyInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class BankruptcyDRSInfoEntity : AbstractCaseInfoDocId, IBackEndSpecificEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="BankruptcyInfoEntity"/> class.</summary>
        public BankruptcyDRSInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the IsAnotherDefField field.
        /// </summary>
        /// <value>The is another def field.</value>
        public DateTime? AnnullmentS123AEffDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is another BA filed.
        /// </summary>
        /// <value>The is another BA filed.</value>
        public DateTime? AnnullmentS95AEffDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the BankruptcyInfoId field.
        /// </summary>
        /// <value>The bankruptcy info id.</value>
        public String BankruptcyDRSInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ExecutionCompDate field.
        /// </summary>
        /// <value>The execution comp date.</value>
        public DateTime? DischargeS125EffDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the DeathToDate field.
        /// </summary>
        /// <value>The death to date.</value>
        public DateTime? DRSEffectiveDate
        {
            get; set;
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

            BankruptcyDRSInfoEntity toCompareWith = obj as BankruptcyDRSInfoEntity;
            return toCompareWith == null ? false : ((this.BankruptcyDRSInfoId == toCompareWith.BankruptcyDRSInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BankruptcyDRSInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}