#region Header

/*****************************************************************************************************
 * Description : This file represents a standard interface for creating instances of objects related
 *              with Legal Aid Process.
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
// File: ILAPFactory.cs
// Description: Represents a standard interface for creating instances of objects related with Legal Aid Process.
// </summary>
// <copyright file= "ILAPFactory.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory
{
    using AllInOne.Legal.Domain.LAP;

    /// <summary>
    /// Represents a standard interface for creating instances of objects related with Legal Aid Process.
    /// </summary>
    internal interface ILAPFactory
    {
        #region Methods

        /// <summary>
        /// Gets the <see cref="LABPartyAddressEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LABPartyAddressEntity"/></returns>
        LABPartyAddressEntity GetLABPartyAddressEntityInstance();

        /// <summary>
        /// Gets the <see cref="LABPartyAddressHistoryEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LABPartyAddressHistoryEntity"/></returns>
        LABPartyAddressHistoryEntity GetLABPartyAddressHistoryEntityInstance();

        /// <summary>
        /// Gets the <see cref="LABPartyEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LABPartyEntity"/></returns>
        LABPartyEntity GetLABPartyEntityInstance();

        /// <summary>
        /// Gets the <see cref="LABPartyHistoryEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LABPartyHistoryEntity"/></returns>
        LABPartyHistoryEntity GetLABPartyHistoryEntityInstance();

        /// <summary>
        /// Gets the <see cref="LABPartySolicitorEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LABPartySolicitorEntity"/></returns>
        LABPartySolicitorEntity GetLABPartySolicitorEntityInstance();

        /// <summary>
        /// Gets the <see cref="LABPartySolicitorHistoryEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LABPartySolicitorHistoryEntity"/></returns>
        LABPartySolicitorHistoryEntity GetLABPartySolicitorHistoryEntityInstance();

        /// <summary>
        /// Gets the <see cref="LABSection17CertInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LABSection17CertInfoEntity"/></returns>
        LABSection17CertInfoEntity GetLABSection17CertInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="LACCancellationInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LACCancellationInfoEntity"/></returns>
        LACCancellationInfoEntity GetLACCancellationInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="LACDocumentDetailEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LACDocumentDetailEntity"/></returns>
        LACDocumentDetailEntity GetLACDocumentDetailEntityInstance();

        /// <summary>
        /// Gets the <see cref="LACDocumentDraftEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LACDocumentDraftEntity"/></returns>
        LACDocumentDraftEntity GetLACDocumentDraftEntityInstance();

        /// <summary>
        /// Gets the <see cref="LACDocumentRemarkEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LACDocumentRemarkEntity"/></returns>
        LACDocumentRemarkEntity GetLACDocumentRemarkEntityInstance();

        /// <summary>
        /// Gets the <see cref="LACInfoEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LACInfoEntity"/></returns>
        LACInfoEntity GetLACInfoEntityInstance();

        /// <summary>
        /// Gets the <see cref="LACUmbrellaUserEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LACUmbrellaUserEntity"/></returns>
        LACUmbrellaUserEntity GetLACUmbrellaUserEntityInstance();

        /// <summary>
        /// Gets the <see cref="LAPInterfaceFileEntity"/> instance.
        /// </summary>
        /// <returns>Returns <see cref="LAPInterfaceFileEntity"/></returns>
        LAPInterfaceFileEntity GetLAPInterfaceFileEntityInstance();

        #endregion Methods
    }
}