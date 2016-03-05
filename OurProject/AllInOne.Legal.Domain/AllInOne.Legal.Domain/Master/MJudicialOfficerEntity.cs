#region Header

/*****************************************************************************************************
* Description : This file represents a standard MAlertEvent entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MAlertEventEntity.cs
// Description: Represents a standard MAlertEvent entity.
// </summary>
// <copyright file= "MAlertEventEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MAlertEvent.
    /// </summary>
    [Serializable]
    public class MJudicialOfficerEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CourtID field.
        /// </summary>
        /// <value>The CourtID.</value>
        public String CourtID
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the DesignationCode field.
        /// </summary>
        /// <value>The DesignationCode.</value>
        public String DesignationCode
        {
            get; set;
        }

        /// <summary>
        /// Gets the UserId field.
        /// </summary>
        /// <value>The UserId.</value>
        public String UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UserName field.
        /// </summary>
        /// <value>The UserName.</value>
        public String UserName
        {
            get; set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            MJudicialOfficerEntity toCompareWith = obj as MJudicialOfficerEntity;
            return toCompareWith == null ? false : ((this.UserId == toCompareWith.UserId)
                && (this.DesignationCode == toCompareWith.DesignationCode)
                && (this.CourtID == toCompareWith.CourtID));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CourtID.GetHashCode();
            toReturn ^= this.DesignationCode.GetHashCode();
            toReturn ^= this.UserId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}