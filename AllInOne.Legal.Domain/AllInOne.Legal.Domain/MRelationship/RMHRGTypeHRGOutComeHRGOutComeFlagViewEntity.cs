#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMCaseTypeForum entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   30/01/2012   		      Nithin             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: RMCaseTypeForumEntity.cs
// Description: Represents a standard RMCaseTypeForum entity.
// </summary>
// <copyright file= "RMCaseTypeForumEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.MRelationship
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'MRelationship.RMHRGTypeHRGOutComeHRGOutComeFlagEntity'</summary>
    [Serializable]
    public class RMHRGTypeHRGOutComeHRGOutComeFlagViewEntity : AbstractLastModified, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public String RMHRGTypeOutcomeFlagId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public String HRGTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGType field. </summary>
        public String HRGType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the court id.
        /// </summary>
        /// <value>
        /// The court id.
        /// </value>
        public String CourtId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the court.
        /// </summary>
        /// <value>
        /// The court.
        /// </value>
        public String Court
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
        /// Gets or sets the NOACode field.
        /// </summary>
        /// <value>
        /// The HRG out come code.
        /// </value>
        public String HRGOutComeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRG out come.
        /// </summary>
        /// <value>
        /// The HRG out come.
        /// </value>
        public String HRGOutCome
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public String HRGOutComeFlagCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRG out come flag.
        /// </summary>
        /// <value>
        /// The HRG out come flag.
        /// </value>
        public String HRGOutComeFlag
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
            RMHRGTypeHRGOutComeHRGOutComeFlagEntity toCompareWith = obj as RMHRGTypeHRGOutComeHRGOutComeFlagEntity;
            return toCompareWith == null ? false : ((this.RMHRGTypeOutcomeFlagId == toCompareWith.RMHRGTypeOutcomeFlagId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RMHRGTypeOutcomeFlagId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}