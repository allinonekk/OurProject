#region Header

/***********************************************************************************************************************
* Description : This file represents a standard data container object for ServiceOfDoc sub case type.
*
*-----------------------------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------------------------
*   25/10/2010   		        Swaroop             	Created
*   01/12/2010                  Rajeev                  Added new property named "ListServiceOfDocDocumentEntity".
*   02/12/2010                  Rajeev                  Added new property named "ListRefOrderDetailEntity".
************************************************************************************************************************/
// <summary>
// File: ServiceOfDocData.cs
// Description: Represents a standard data container object for ServiceOfDoc sub case type.
// </summary>
// <copyright file= "ServiceOfDocData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCaseData
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.SubCaseSpecific;

    /// <summary>
    /// Represents a standard data container object for ServiceOfDoc sub case type.
    /// </summary>
    [Serializable]
    public class ServiceOfDocData : ISubCaseTypeInfo
    {
        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="ListRefOrderDetailEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="ListRefOrderDetailEntity"/> entity.</value>
        public List<RefOrderDetailEntity> ListRefOrderDetailEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list of <see cref="ServiceOfDocDocStatusHistoryEntity"/> entity.
        /// </summary>
        /// <value>The list of <see cref="ServiceOfDocDocStatusHistoryEntity"/> entity.</value>
        public List<ServiceOfDocDocStatusHistoryEntity> ListServiceOfDocDocStatusHistoryEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="ServiceOfDocDocumentEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="ServiceOfDocDocumentEntity"/> entity.</value>
        public List<ServiceOfDocDocumentEntity> ListServiceOfDocDocumentEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list of <see cref="ServiceOfDocInfoDetailEntity"/> entity.
        /// </summary>
        /// <value>The list of <see cref="ServiceOfDocInfoDetailEntity"/> entity.</value>
        public List<ServiceOfDocInfoDetailEntity> ListServiceOfDocInfoDetailEntity
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the <see cref="ServiceOfDocInfoEntity"/> entity.
        /// </summary>
        /// <value>The <see cref="ServiceOfDocInfoEntity"/> entity.</value>
        public ServiceOfDocInfoEntity ServiceOfDocInfoEntity
        {
            get;
            set;
        }

        #endregion Properties
    }
}