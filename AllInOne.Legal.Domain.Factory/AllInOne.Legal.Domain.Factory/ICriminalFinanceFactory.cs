#region Header

/*****************************************************************************************************
 * Description : This file represents a standard interface for creating instances of objects related
 *              with criminal finance.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 04/10/2010                 Chun Jie             	 	Created
 *****************************************************************************************************/
// <summary>
// File: ICriminalFinanceFactory.cs
// Description: Represents a standard interface for creating instances of objects related with case.
// </summary>
// <copyright file= "ICriminalFinanceFactory.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory
{
    using AllInOne.Legal.Domain.BackEndSpecific;

    /// <summary>
    /// Represents a standard interface for creating instances of objects related with document.
    /// </summary>
    internal interface ICriminalFinanceFactory
    {
        #region Methods

        /// <summary>
        /// Gets the <see cref="CriminalClaimHonorariumInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CriminalClaimHonorariumInfoEntity"/></returns>
        CriminalClaimHonorariumInfoEntity GetCriminalClaimHonorariumInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="CriminalClaimInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CriminalClaimInfoEntity"/></returns>
        CriminalClaimInfoEntity GetCriminalClaimInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="CriminalClaimInterpreterFeeInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CriminalClaimInterpreterFeeInfoEntity"/></returns>
        CriminalClaimInterpreterFeeInfoEntity GetCriminalClaimInterpreterFeeInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="CriminalClaimMiscellaneousInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CriminalClaimMiscellaneousInfoEntity"/></returns>
        CriminalClaimMiscellaneousInfoEntity GetCriminalClaimMiscellaneousInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="CriminalClaimProfessionalFeeInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CriminalClaimProfessionalFeeInfoEntity"/></returns>
        CriminalClaimProfessionalFeeInfoEntity GetCriminalClaimProfessionalFeeInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="CriminalClaimWitnessInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="CriminalClaimWitnessInfoEntity"/></returns>
        CriminalClaimWitnessInfoEntity GetCriminalClaimWitnessInfoEntityInstance();

        #endregion Methods
    }
}