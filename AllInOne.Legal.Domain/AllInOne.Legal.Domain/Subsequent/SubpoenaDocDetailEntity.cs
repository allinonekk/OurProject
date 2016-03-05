#region Header

/*****************************************************************************************************
 * Description : This file represents a standard SubpoenaDocDetailEntity.
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
// File: SubpoenaDocDetailEntity.cs
// Description: Represents a standard SubPoenaInfoEntity.
// </summary>
// <copyright file= "SubpoenaDocDetailEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for SubpoenaDocDetailEntity.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class SubpoenaDocDetailEntity : AbstractSubmissionGroup, ISubsequentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the doc name and desc.
        /// </summary>
        /// <value>The doc name and desc.</value>
        public String DocNameAndDesc
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the subpoena doc detail id.
        /// </summary>
        /// <value>The subpoena doc detail id.</value>
        public String SubpoenaDocDetailId
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
            SubpoenaDocDetailEntity toCompareWith = obj as SubpoenaDocDetailEntity;
            return toCompareWith == null ? false : ((this.SubpoenaDocDetailId == toCompareWith.SubpoenaDocDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SubpoenaDocDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}