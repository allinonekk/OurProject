#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for ReportConfigUser.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   19/12/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: ReportConfigUserEntity.cs
// Description: Represents a standard domain entity for ReportConfigUser.
// </summary>
// <copyright file= "ReportConfigUserEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for ReportConfigUser.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class ReportConfigUserEntity : AbstractLastModified, IBackEndSpecificEntity
    {
        #region Properties

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
        /// Gets or sets the ReportConfigInfoId field.
        /// </summary>
        /// <value>The report config info id.</value>
        public String ReportConfigInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ReportConfigUserId field.
        /// </summary>
        /// <value>The report config user id.</value>
        public String ReportConfigUserId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'BackEndSpecific.ReportConfigUser.JudicialUser - BackEndSpecific.JudicialUser.ReportConfigUsers (m:1)'
        /// </summary>
        /// <value>The judicial user entity.</value>
        public String UserId
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
            if(obj == null)
            {
                return false;
            }

            ReportConfigUserEntity toCompareWith = obj as ReportConfigUserEntity;
            return toCompareWith == null ? false : ((this.ReportConfigUserId == toCompareWith.ReportConfigUserId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ReportConfigUserId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}