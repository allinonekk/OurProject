#region Header

/*****************************************************************************************************
* Description : This file represents a standard InvestigatingOfficerInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   20/01/2011   		      CJ                 	 	Created
*
*****************************************************************************************************/
// <summary>
// File: InvestigatingOfficerInfoEntity.cs
// Description: Represents a standard InvestigatingOfficerInfo entity.
// </summary>
// <copyright file= "InvestigatingOfficerInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'CaseSpecific.InvestigatingOfficerInfo'</summary>
    [Serializable]
    public class InvestigatingOfficerInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the Designation field. </summary>
        public String Designation
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Email field. </summary>
        public String Email
        {
            get;
            set;
        }

        /// <summary>Gets or sets the InvestigatingOfficerInfoId field. </summary>
        public String InvestigatingOfficerInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.InvestigatingOfficerInfo.MIOOrganisation - Master.MIOOrganisation.InvestigatingOfficerInfos (m:1)'</summary>
        public MIOOrganisationEntity MIOOrganisation
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MobileNo field. </summary>
        public String MobileNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Name field. </summary>
        public String Name
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PhoneNo field. </summary>
        public String PhoneNo
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
            InvestigatingOfficerInfoEntity toCompareWith = obj as InvestigatingOfficerInfoEntity;
            return toCompareWith == null ? false : ((this.InvestigatingOfficerInfoId == toCompareWith.InvestigatingOfficerInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.InvestigatingOfficerInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}