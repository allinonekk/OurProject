#region Header

/*****************************************************************************************************
* Description : This file represents a standard InterfaceICA entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			        Author			        Description
*-----------------------------------------------------------------------------------------------------
* 15/10/2010                Swaroop             	 	Created
*****************************************************************************************************/
// <summary>
// File: InterfaceICAEntity.cs
// Description: Represents a standard InterfaceICA entity.
// </summary>
// <copyright file= "InterfaceICAEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for InterfaceICA.
    /// It inherits from <see cref="AbstractDocId"/>
    /// </summary>
    [Serializable]
    public class IndexDocInfoEntity : AbstractDocId, IBackEndSpecificEntity
    {
        #region Properties

        public long IndexDocInfoPKID
        {
            get;
            set;
        }

        public String IndexDocInfoId
        {
            get;
            set;
        }

        public YesNo ObsInd
        {
            get;
            set;
        }

        public String UserId
        {
            get;
            set;
        }

        public String DocGroupID
        {
            get;
            set;
        }

        #endregion Properties
    }
}