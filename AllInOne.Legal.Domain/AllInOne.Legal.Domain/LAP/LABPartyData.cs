#region Header

/*****************************************************************************************************
* Description : This file represents a standard data container object for LABParty.
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
// File: LABPartyData.cs
// Description: Represents a standard data container object for LABParty.
// </summary>
// <copyright file= "LABPartyData.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LAP
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard data container object for LABParty.
    /// </summary>
    [Serializable]
    public class LABPartyData : ILABPartyData
    {
        #region Properties

        /// <summary>
        /// Gets or sets the LAB party entity.
        /// </summary>
        /// <value>The LAB party entity.</value>
        public LABPartyEntity LABParty
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list LAB party addresses.
        /// </summary>
        /// <value>The list LAB party addresses.</value>
        public List<LABPartyAddressEntity> ListLABPartyAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list LAB party solicitors.
        /// </summary>
        /// <value>The list LAB party solicitors.</value>
        public List<LABPartySolicitorEntity> ListLABPartySolicitors
        {
            get;
            set;
        }

        #endregion Properties
    }
}