#region Header

/*****************************************************************************************************
 * Description : This file represents a standard interface for creating instances of objects related
 *              with case.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 04/10/2010                 Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: IDocumentFactory.cs
// Description: Represents a standard interface for creating instances of objects related with case.
// </summary>
// <copyright file= "IDocumentFactory.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory
{
    using AllInOne.Legal.Domain.CaseSpecific;

    /// <summary>
    /// Represents a standard interface for creating instances of objects related with document.
    /// </summary>
    internal interface ICaseSpecificFactory
    {
        #region Methods

        /// <summary>
        /// Gets the <see cref="AASObjectionEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="AASObjectionEntity"/></returns>
        AASObjectionEntity GetAASObjectionEntityInstance();

        /// <summary>
        /// Gets the <see cref="ADMInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="ADMInfoEntity"/></returns>
        ADMInfoEntity GetADMInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="BanruptcyInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="BanruptcyInfoEntity"/>
        /// </returns>
        BankruptcyInfoEntity GetBankruptcyInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="BankruptcyOtherDefDetailEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="BankruptcyOtherDefDetailEntity"/>
        /// </returns>
        BankruptcyOtherDefDetailEntity GetBankruptcyOtherDefDetailEntityInstance();

        /// <summary>
        /// Gets the <see cref="BillOfSaleInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="BillOfSaleInfoEntity"/>
        /// </returns>
        BillOfSaleInfoEntity GetBillOfSaleInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="ChargeInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="ChargeInfoEntity"/>
        /// </returns>
        ChargeInfoEntity GetChargeInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="CriminalInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CriminalInfoEntity"/>
        /// </returns>
        CriminalInfoEntity GetCriminalInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="CriminalOtherOrderInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CriminalOtherOrderInfoEntity"/>
        /// </returns>
        CriminalOtherOrderInfoEntity GetCriminalOtherOrderInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="CWUCheckListInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CWUCheckListInfoEntity"/>
        /// </returns>
        CWUCheckListInfoEntity GetCWUCheckListInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="CWUInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CWUInfoEntity"/>
        /// </returns>
        CWUInfoEntity GetCWUInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="DCACAInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DCACAInfoEntity"/>
        /// </returns>
        DCACAInfoEntity GetDCACAInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="DrugInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DrugInfoEntity"/>
        /// </returns>
        DrugInfoEntity GetDrugInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="InvestigatingOfficerInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="InvestigatingOfficerInfoEntity"/>
        /// </returns>
        InvestigatingOfficerInfoEntity GetInvestigatingOfficerInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="OffenceInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="OffenceInfoEntity"/>
        /// </returns>
        OffenceInfoEntity GetOffenceInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="OSInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="OSInfoEntity"/>
        /// </returns>
        OSInfoEntity GetOSInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="RCriminalLegislationInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="RCriminalLegislationInfoEntity"/>
        /// </returns>
        RCriminalLegislationInfoEntity GetRCriminalLegislationInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="SentenceInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="SentenceInfoEntity"/>
        /// </returns>
        SentenceInfoEntity GetSentenceInfoEntityInstance();

        #endregion Methods
    }
}