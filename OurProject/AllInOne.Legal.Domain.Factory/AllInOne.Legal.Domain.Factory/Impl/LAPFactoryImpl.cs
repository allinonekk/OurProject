#region Header

/*****************************************************************************************************
 * Description : This file represents a standard implementation for Legal Aid Process factory.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 22/10/2010                 Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: LAPFactory.cs
// Description: Represents a standard implementation for Legal Aid Process factory.
// </summary>
// <copyright file= "LAPFactory.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory.Impl
{
    using AllInOne.Legal.Domain.LAP;

    /// <summary>
    /// Represents a standard implementation for Legal Aid Process factory.
    /// It inherits from <see cref="ILAPFactory"/>.
    /// </summary>
    public class LAPFactoryImpl : ILAPFactory
    {
        #region Fields

        /// <summary>
        /// Variable to store ApplicationEnvironment.
        /// </summary>
        private ApplicationEnvironment applicationEnvironment;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LAPFactoryImpl"/> class.
        /// </summary>
        /// <param name="applicationEnvironment">The application environment.</param>
        public LAPFactoryImpl(ApplicationEnvironment applicationEnvironment)
        {
            this.applicationEnvironment = applicationEnvironment;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the <see cref="LABPartyAddressEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LABPartyAddressEntity"/>
        /// </returns>
        public LABPartyAddressEntity GetLABPartyAddressEntityInstance()
        {
            return new LABPartyAddressEntity { LABPartyAddressId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LABPartyAddressHistoryEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LABPartyAddressHistoryEntity"/>
        /// </returns>
        public LABPartyAddressHistoryEntity GetLABPartyAddressHistoryEntityInstance()
        {
            return new LABPartyAddressHistoryEntity { LABPartyAddressHistoryId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LABPartyEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LABPartyEntity"/></returns>
        public LABPartyEntity GetLABPartyEntityInstance()
        {
            return new LABPartyEntity { LABPartyId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LABPartyHistoryEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LABPartyHistoryEntity"/>
        /// </returns>
        public LABPartyHistoryEntity GetLABPartyHistoryEntityInstance()
        {
            return new LABPartyHistoryEntity { LABPartyHistoryId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LABPartySolicitorEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LABPartySolicitorEntity"/>
        /// </returns>
        public LABPartySolicitorEntity GetLABPartySolicitorEntityInstance()
        {
            return new LABPartySolicitorEntity { LABPartySolicitorId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LABPartySolicitorHistoryEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LABPartySolicitorHistoryEntity"/>
        /// </returns>
        public LABPartySolicitorHistoryEntity GetLABPartySolicitorHistoryEntityInstance()
        {
            return new LABPartySolicitorHistoryEntity { LABPartySolicitorHistoryId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LABSection17CertInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LABSection17CertInfoEntity"/>
        /// </returns>
        public LABSection17CertInfoEntity GetLABSection17CertInfoEntityInstance()
        {
            return new LABSection17CertInfoEntity { Section17CertId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LACCancellationInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LACCancellationInfoEntity"/>
        /// </returns>
        public LACCancellationInfoEntity GetLACCancellationInfoEntityInstance()
        {
            return new LACCancellationInfoEntity { CancellationId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LACDocumentDetailEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LACDocumentDetailEntity"/>
        /// </returns>
        public LACDocumentDetailEntity GetLACDocumentDetailEntityInstance()
        {
            return new LACDocumentDetailEntity { LACDocDetailId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LACDocumentDraftEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LACDocumentDraftEntity"/>
        /// </returns>
        public LACDocumentDraftEntity GetLACDocumentDraftEntityInstance()
        {
            return new LACDocumentDraftEntity { LACDocDraftId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LACDocumentRemarkEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LACDocumentRemarkEntity"/>
        /// </returns>
        public LACDocumentRemarkEntity GetLACDocumentRemarkEntityInstance()
        {
            return new LACDocumentRemarkEntity { LACDocRemarkId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LACInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LACInfoEntity"/></returns>
        public LACInfoEntity GetLACInfoEntityInstance()
        {
            return new LACInfoEntity { LACInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LACUmbrellaUserEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LACUmbrellaUserEntity"/>
        /// </returns>
        public LACUmbrellaUserEntity GetLACUmbrellaUserEntityInstance()
        {
            return new LACUmbrellaUserEntity { LACUserCreationId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LAPInterfaceFileEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LAPInterfaceFileEntity"/>
        /// </returns>
        public LAPInterfaceFileEntity GetLAPInterfaceFileEntityInstance()
        {
            return new LAPInterfaceFileEntity { FileId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        #endregion Methods
    }
}