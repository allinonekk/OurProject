#region Header

/*****************************************************************************************************
 * Description : This file represents a standard implementation for case factory.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 21/02/20110                 Chun Jie             	 	Created
 *****************************************************************************************************/
// <summary>
// File: CaseSpecificFactoryImpl.cs
// Description: Represents a standard implementation for case specific factory.
// </summary>
// <copyright file= "CaseSpecificFactoryImpl.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory.Impl
{
    using AllInOne.Legal.Domain.CaseSpecific;

    /// <summary>
    /// Represents a standard implementation for case factory.
    /// It inherits from <see cref="ICaseFactory"/>.
    /// </summary>
    public class CaseSpecificFactoryImpl : ICaseSpecificFactory
    {
        #region Fields

        /// <summary>
        /// Variable to store ApplicationEnvironment.
        /// </summary>
        private ApplicationEnvironment applicationEnvironment;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseFactoryImpl"/> class.
        /// </summary>
        /// <param name="applicationEnvironment">The application environment.</param>
        public CaseSpecificFactoryImpl(ApplicationEnvironment applicationEnvironment)
        {
            this.applicationEnvironment = applicationEnvironment;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the <see cref="AASObjectionEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="AASObjectionEntity"/>
        /// </returns>
        public AASObjectionEntity GetAASObjectionEntityInstance()
        {
            return new AASObjectionEntity { AASObjectionId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="ADMInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="ADMInfoEntity"/>
        /// </returns>
        public ADMInfoEntity GetADMInfoEntityInstance()
        {
            return new ADMInfoEntity { ADMInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="BanruptcyInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="BanruptcyInfoEntity"/>
        /// </returns>
        public BankruptcyInfoEntity GetBankruptcyInfoEntityInstance()
        {
            return new BankruptcyInfoEntity { BankruptcyInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="BankruptcyOtherDefDetailEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="BankruptcyOtherDefDetailEntity"/>
        /// </returns>
        public BankruptcyOtherDefDetailEntity GetBankruptcyOtherDefDetailEntityInstance()
        {
            return new BankruptcyOtherDefDetailEntity { OtherDefendantId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="BillOfSaleInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="BillOfSaleInfoEntity"/>
        /// </returns>
        public BillOfSaleInfoEntity GetBillOfSaleInfoEntityInstance()
        {
            return new BillOfSaleInfoEntity { BillOfSaleInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="ChargeInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="ChargeInfoEntity"/>
        /// </returns>
        public ChargeInfoEntity GetChargeInfoEntityInstance()
        {
            return new ChargeInfoEntity { ChargeInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CriminalInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CriminalInfoEntity"/>
        /// </returns>
        public CriminalInfoEntity GetCriminalInfoEntityInstance()
        {
            return new CriminalInfoEntity { CriminalInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CriminalOtherOrderInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CriminalOtherOrderInfoEntity"/>
        /// </returns>
        public CriminalOtherOrderInfoEntity GetCriminalOtherOrderInfoEntityInstance()
        {
            return new CriminalOtherOrderInfoEntity { CriminalOtherOrderInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CWUCheckListInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CWUCheckListInfoEntity"/>
        /// </returns>
        public CWUCheckListInfoEntity GetCWUCheckListInfoEntityInstance()
        {
            return new CWUCheckListInfoEntity { CWUChecklistInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CWUInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CWUInfoEntity"/>
        /// </returns>
        public CWUInfoEntity GetCWUInfoEntityInstance()
        {
            return new CWUInfoEntity { CWUInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DCACAInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DCACAInfoEntity"/>
        /// </returns>
        public DCACAInfoEntity GetDCACAInfoEntityInstance()
        {
            return new DCACAInfoEntity { DCACAInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DrugInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DrugInfoEntity"/>
        /// </returns>
        public DrugInfoEntity GetDrugInfoEntityInstance()
        {
            return new DrugInfoEntity { DrugInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="InvestigatingOfficerInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="InvestigatingOfficerInfoEntity"/>
        /// </returns>
        public InvestigatingOfficerInfoEntity GetInvestigatingOfficerInfoEntityInstance()
        {
            return new InvestigatingOfficerInfoEntity { InvestigatingOfficerInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="OffenceInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="OffenceInfoEntity"/>
        /// </returns>
        public OffenceInfoEntity GetOffenceInfoEntityInstance()
        {
            return new OffenceInfoEntity { OffenceInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="OSInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="OSInfoEntity"/>
        /// </returns>
        public OSInfoEntity GetOSInfoEntityInstance()
        {
            return new OSInfoEntity { OSInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="RCriminalLegislationInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="RCriminalLegislationInfoEntity"/>
        /// </returns>
        public RCriminalLegislationInfoEntity GetRCriminalLegislationInfoEntityInstance()
        {
            return new RCriminalLegislationInfoEntity { RCriminalLegislationInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="SentenceInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="SentenceInfoEntity"/>
        /// </returns>
        public SentenceInfoEntity GetSentenceInfoEntityInstance()
        {
            return new SentenceInfoEntity { SentenceInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        #endregion Methods
    }
}