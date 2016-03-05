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
// File: CriminalFinanceFactoryImpl.cs
// Description: Represents a standard interface for creating instances of objects related with case.
// </summary>
// <copyright file= "CriminalFinanceFactoryImpl.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory.Impl
{
    using AllInOne.Legal.Domain.BackEndSpecific;

    /// <summary>
    /// Represents a standard implementation for criminal finance factory.
    /// It inherits from <see cref="ICriminalFinanceFactory"/>.
    /// </summary>
    public class CriminalFinanceFactoryImpl : ICriminalFinanceFactory
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
        public CriminalFinanceFactoryImpl(ApplicationEnvironment applicationEnvironment)
        {
            this.applicationEnvironment = applicationEnvironment;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the <see cref="CriminalClaimHonorariumInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CriminalClaimHonorariumInfoEntity"/>
        /// </returns>
        public CriminalClaimHonorariumInfoEntity GetCriminalClaimHonorariumInfoEntityInstance()
        {
            return new CriminalClaimHonorariumInfoEntity { CriminalClaimHonorariumInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CriminalClaimInfoEntity"/>
        /// </returns>
        public CriminalClaimInfoEntity GetCriminalClaimInfoEntityInstance()
        {
            return new CriminalClaimInfoEntity { CriminalClaimInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimInterpreterFeeInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CriminalClaimInterpreterFeeInfoEntity"/>
        /// </returns>
        public CriminalClaimInterpreterFeeInfoEntity GetCriminalClaimInterpreterFeeInfoEntityInstance()
        {
            return new CriminalClaimInterpreterFeeInfoEntity { CriminalClaimInterpreterFeeInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimMiscellaneousInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CriminalClaimMiscellaneousInfoEntity"/>
        /// </returns>
        public CriminalClaimMiscellaneousInfoEntity GetCriminalClaimMiscellaneousInfoEntityInstance()
        {
            return new CriminalClaimMiscellaneousInfoEntity { CriminalClaimMiscellaneousInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimProfessionalFeeInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CriminalClaimProfessionalFeeInfoEntity"/>
        /// </returns>
        public CriminalClaimProfessionalFeeInfoEntity GetCriminalClaimProfessionalFeeInfoEntityInstance()
        {
            return new CriminalClaimProfessionalFeeInfoEntity { CriminalClaimProfessionalFeeInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="CriminalClaimWitnessInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="CriminalClaimWitnessInfoEntity"/>
        /// </returns>
        public CriminalClaimWitnessInfoEntity GetCriminalClaimWitnessInfoEntityInstance()
        {
            return new CriminalClaimWitnessInfoEntity { CriminalClaimWitnessInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        #endregion Methods
    }
}