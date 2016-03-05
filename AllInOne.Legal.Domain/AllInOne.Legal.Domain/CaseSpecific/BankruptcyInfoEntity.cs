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

namespace AllInOne.Legal.Domain.CaseSpecific
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
    public class BankruptcyInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="BankruptcyInfoEntity"/> class.</summary>
        public BankruptcyInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'BankruptcyInfoEntity.BBCode - MBankruptcyBasisEntity.BBCode'
        /// </summary>
        /// <value>The Bankruptcy basis.</value>
        public MBankruptcyBasisEntity BankruptcyBasis
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the BankruptcyInfoId field.
        /// </summary>
        /// <value>The bankruptcy info id.</value>
        public String BankruptcyInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'BankruptcyInfoEntity.BTCode - MBankruptcyTypeEntity.BTCode'
        /// </summary>
        /// <value>The type of the Bankruptcy.</value>
        public MBankruptcyTypeEntity BankruptcyType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the DeathFromDate field.
        /// </summary>
        /// <value>The death from date.</value>
        public DateTime? DeathFromDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the DeathToDate field.
        /// </summary>
        /// <value>The death to date.</value>
        public DateTime? DeathToDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ExecutionCompDate field.
        /// </summary>
        /// <value>The execution comp date.</value>
        public DateTime? ExecutionCompDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the is another BA filed.
        /// </summary>
        /// <value>The is another BA filed.</value>
        public YesNo IsAnotherBAFiled
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the IsAnotherDefField field.
        /// </summary>
        /// <value>The is another def field.</value>
        public YesNo IsAnotherDefField
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is service out jur.
        /// </summary>
        /// <value>The is service out jur.</value>
        public JurisdictionInSingapore IsServiceOutJur
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'BankruptcyInfoEntity.CurrencyCode - MCurrencyEntity.CurrencyCode'
        /// </summary>
        /// <value>The M currency.</value>
        public MCurrencyEntity MCurrency
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ProbateCaseNo field.
        /// </summary>
        /// <value>The probate case no.</value>
        public String ProbateCaseNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the RevCertIssueDate field.
        /// </summary>
        /// <value>The rev cert issue date.</value>
        public DateTime? RevCertIssueDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the StatuaryDemandDate field.
        /// </summary>
        /// <value>The statuary demand date.</value>
        public DateTime? StatuaryDemandDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the TotalDebt field.
        /// </summary>
        /// <value>The total debt.</value>
        public decimal? TotalDebt
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the TotalDebtinSGD field.
        /// </summary>
        /// <value>The total debtin SGD.</value>
        public decimal? TotalDebtInSGD
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

            BankruptcyInfoEntity toCompareWith = obj as BankruptcyInfoEntity;
            return toCompareWith == null ? false : ((this.BankruptcyInfoId == toCompareWith.BankruptcyInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BankruptcyInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}