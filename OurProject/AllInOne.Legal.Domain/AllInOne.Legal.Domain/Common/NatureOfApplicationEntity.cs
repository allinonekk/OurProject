#region Header

/*****************************************************************************************************
* Description : This file represents a standard NatureOfApplication entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   04/01/2011  		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: NatureOfApplicationEntity.cs
// Description: Represents a standard NatureOfApplication entity.
// </summary>
// <copyright file= "NatureOfApplicationEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for NatureOfApplication.
    /// It inherits from <see cref="AbstractCaseInfoSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class NatureOfApplicationEntity : AbstractCaseInfoSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The item no.</value>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MainInd field.
        /// </summary>
        /// <value>The main ind.</value>
        public YesNo MainInd
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.NatureOfApplication.MNOACode - Master.MNOACode.NatureOfApplications (m:1)'
        /// </summary>
        /// <value>The MNOA code.</value>
        public MNOACodeEntity MNOACodeEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NatureOfApplicationId field.
        /// </summary>
        /// <value>The nature of application id.</value>
        public String NatureOfApplicationId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OtherText field.
        /// </summary>
        /// <value>The other text.</value>
        public String OtherText
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.NatureOfApplication.SubCaseInfo - SubCase.SubCaseInfo.NatureOfApplications (m:1)'
        /// </summary>
        /// <value>The sub case info.</value>
        public Int64? SubCaseInfoId
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            NatureOfApplicationEntity toCompareWith = obj as NatureOfApplicationEntity;
            return toCompareWith == null ? false : ((this.NatureOfApplicationId == toCompareWith.NatureOfApplicationId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NatureOfApplicationId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}