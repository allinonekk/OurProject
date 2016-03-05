#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMCaseTypeHRGTypeJOL entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   26/07/2012   		      Nithin             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: RMCaseTypeHRGTypeJOLViewEntity.cs
// Description: Represents a standard RMCaseTypeHRGTypeJOL entity.
// </summary>
// <copyright file= "RMCaseTypeHRGTypeJOLViewEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.MRelationship
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'MRelationship.RMCaseTypeHRGTypeJOLViewEntity'</summary>
    [Serializable]
    public class RMCaseTypeHRGTypeJOLViewEntity : AbstractLastModified, IMasterEntity
    {
        #region Properties

       
        public string RMCaseTypeHRGTypeJOLId
        {
            get;
            set;
        }
        
        public string ForumId
        {
            get;
            set;
        }

        public string CaseTypeCode
        {
            get;
            set;
        }
        
        public string HRGTypeCode
        {
            get;
            set;
        }

        public string Forum
        {
            get;
            set;
        }

        public string CaseType
        {
            get;
            set;
        }

        public string HRGType
        {
            get;
            set;
        }

        public string ObsInd
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
            RMCaseTypeHRGTypeJOLViewEntity toCompareWith = obj as RMCaseTypeHRGTypeJOLViewEntity;
            return toCompareWith == null ? false : ((this.RMCaseTypeHRGTypeJOLId == toCompareWith.RMCaseTypeHRGTypeJOLId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RMCaseTypeHRGTypeJOLId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}