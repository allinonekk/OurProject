#region Header

/*****************************************************************************************************
* Description : This file represents a standard WOEMOMSCTInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   27/06/2011                 CJ             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: WOEMOMSCTInfoEntity.cs
// Description: Represents a standard WOEMOMSCTInfo entity.
// </summary>
// <copyright file= "WOEMOMSCTInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'CaseSpecific.WOEMOMSCTInfoEntity'</summary>
    [Serializable]
    public partial class WOEMOMSCTInfoEntity : AbstractLastModified, ICaseSpecificEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="WOEMOMSCTInfoEntity"/> class.</summary>
        public WOEMOMSCTInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public DateTime? DateOfOrderByCommOfLabour
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EmpActOrderType field. </summary>
        public WOEEmpActOrderType EmpActOrderType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EmpActSection field. </summary>
        public String EmpActSection
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EnforcementDoc field. </summary>
        public String EnforcementDoc
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsAuthorisedBailiff field. </summary>
        public YesNo IsAuthorisedBailiff
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsExecOutOffHour field. </summary>
        public YesNo IsExecOutOffHour
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MOMSCTCaseNo field. </summary>
        public String MOMSCTCaseNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the OrderEnforced field. </summary>
        public OrderEnforcedTypes OrderEnforced
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubmissionGroupId field. </summary>
        public String SubmissionGroupId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WOEMOMSCTInfoId field. </summary>
        public String WOEMOMSCTInfoId
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
            WOEMOMSCTInfoEntity toCompareWith = obj as WOEMOMSCTInfoEntity;
            return toCompareWith == null ? false : ((this.WOEMOMSCTInfoId == toCompareWith.WOEMOMSCTInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WOEMOMSCTInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}