#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMHRGOutComePartyStatusEntity entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   06/04/2011   		      Nithin             	 	    Created
*   07/07/2011   		      Yan Nai             	 	    Modified
*
*****************************************************************************************************/
// <summary>
// File: RMHRGOutComePartyStatusEntity.cs
// Description: Represents a standard RMHRGOutComePartyStatusEntity entity.
// </summary>
// <copyright file= "RMHRGOutComePartyStatusEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.RMHRGOutComePartyStatusEntity'</summary>
    [Serializable]
    public class RMHRGOutComePartyStatusEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public System.String CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MCaseStatus field. </summary>
        public MCaseStatusEntity MCaseStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MCaseTypeGroup field. </summary>
        public MCaseTypeGroupEntity MCaseTypeGroup
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MHRGOutCome field. </summary>
        public MHRGOutComeEntity MHRGOutCome
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MPartyStatus field. </summary>
        public MPartyStatusEntity MPartyStatus
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NOACode field. </summary>
        public System.String NOACode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the RMHrgOutComePartyStatusId field. </summary>
        public System.String RMHrgOutComePartyStatusId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubCaseTypeCode field. </summary>
        public System.String SubCaseTypeCode
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
            RMHRGOutComePartyStatusEntity toCompareWith = obj as RMHRGOutComePartyStatusEntity;
            return toCompareWith == null ? false : (this.RMHrgOutComePartyStatusId == toCompareWith.RMHrgOutComePartyStatusId);
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RMHrgOutComePartyStatusId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}