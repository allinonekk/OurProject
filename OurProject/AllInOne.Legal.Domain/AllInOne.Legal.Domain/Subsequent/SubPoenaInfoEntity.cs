#region Header

/*****************************************************************************************************
 * Description : This file represents a standard SubPoenaInfoEntity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 23/01/2011   		      Nithin             	 	Created
 *****************************************************************************************************/
// <summary>
// File: SubPoenaInfoEntity.cs
// Description: Represents a standard SubPoenaInfoEntity.
// </summary>
// <copyright file= "SubPoenaInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Subsequent
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for FileInspectionDocDetailsEntity.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class SubpoenaInfoEntity : AbstractSubmissionGroup, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the mode of attendance.
        /// </summary>
        /// <value>The mode of attendance.</value>
        public AttendanceMode ModeOfAttendance
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the purpose of subpoena.
        /// </summary>
        /// <value>The purpose of subpoena.</value>
        public SubpoenaPurpose PurposeOfSubpoena
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the selected HRG id.
        /// </summary>
        /// <value>The selected HRG id.</value>
        public Int64? SelectedHrgId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the subpoena info id.
        /// </summary>
        /// <value>The subpoena info id.</value>
        public string SubpoenaInfoId
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
            SubpoenaInfoEntity toCompareWith = obj as SubpoenaInfoEntity;
            return toCompareWith == null ? false : ((this.SubpoenaInfoId == toCompareWith.SubpoenaInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SubpoenaInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}