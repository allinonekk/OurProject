#region Header

/*****************************************************************************************************
 * Description : This file represents a standard implementation for SubCase factory.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 02/11/2010                 Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: SubCaseFactoryImpl.cs
// Description: Represents a standard implementation for SubCase factory.
// </summary>
// <copyright file= "SubCaseFactoryImpl.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory.Impl
{
    using AllInOne.Legal.Domain.SubCase;

    /// <summary>
    /// Represents a standard implementation for SubCase factory.
    /// It inherits from <see cref="ISubCaseFactory"/>.
    /// </summary>
    public class SubCaseFactoryImpl : ISubCaseFactory
    {
        #region Fields

        /// <summary>
        /// Variable to store ApplicationEnvironment.
        /// </summary>
        private ApplicationEnvironment applicationEnvironment;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SubCaseFactoryImpl"/> class.
        /// </summary>
        /// <param name="applicationEnvironment">The application environment.</param>
        public SubCaseFactoryImpl(ApplicationEnvironment applicationEnvironment)
        {
            this.applicationEnvironment = applicationEnvironment;
        }

        #endregion Constructors

        #region Methods

        public RelationalSubCaseInfoEntity GetRelationalSubCaseInfoEntityInstance()
        {
            return new RelationalSubCaseInfoEntity { RelationalSubCaseInfoId = FactoryUtil.GetPrimaryKey(applicationEnvironment) };
        }

        public RSubCaseSubmissionEntity GetRSubCaseSubmissionEntityInstance()
        {
            return new RSubCaseSubmissionEntity { RSubCaseSubmissionId = FactoryUtil.GetPrimaryKey(applicationEnvironment) };
        }

        public SubCasePartyEntity GetSubCasePartyEntityInstance()
        {
            return new SubCasePartyEntity { SubCasePartyId = FactoryUtil.GetPrimaryKey(applicationEnvironment) };
        }
        
        public SubCaseStatusHistoryEntity GetSubCaseStatusHistoryEntityInstance()
        {
            return new SubCaseStatusHistoryEntity { SubCaseStatusHistoryId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        #endregion Methods
    }
}