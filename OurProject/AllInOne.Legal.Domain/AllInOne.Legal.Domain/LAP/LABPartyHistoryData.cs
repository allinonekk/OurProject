#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for LABPartyHistory.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LABPartyHistoryData.cs
// Description: Represents a standard data container object for LABPartyHistory.
// </summary>
// <copyright file= "LABPartyHistoryData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LAP
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard data container object for LABPartyHistory.
    /// </summary>
    [Serializable]
    public class LABPartyHistoryData : ILABPartyHistoryData
    {
        #region Properties

        /// <summary>
        /// Gets or sets the LAB party history.
        /// </summary>
        /// <value>The LAB party history.</value>
        public LABPartyHistoryEntity LABPartyHistory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list LAB party address history.
        /// </summary>
        /// <value>The list LAB party address history.</value>
        public List<LABPartyAddressHistoryEntity> ListLABPartyAddressHistory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list LAB party solicitor history.
        /// </summary>
        /// <value>The list LAB party solicitor history.</value>
        public List<LABPartySolicitorHistoryEntity> ListLABPartySolicitorHistory
        {
            get;
            set;
        }

        #endregion Properties
    }
}