#region Header

/*****************************************************************************************************
* Description : This file represents a standard BizMonitoringInfoEntity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   29/09/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: BizMonitoringInfoEntity.cs
// Description: Represents a standard BizMonitoringInfo entity.
// </summary>
// <copyright file= "BizMonitoringInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for BizMonitoringInfo.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class BizMonitoringInfoEntity : AbstractLastModified, IBackEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the BizMonitoringInfoId.
        /// </summary>
        /// <value>The BizMonitoringInfoId.</value>
        public String BizMonitoringInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseInfoId.
        /// </summary>
        /// <value>The CaseInfoId.</value>
        public Int64 CaseInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the completion date.
        /// </summary>
        /// <value>The completion date.</value>
        public DateTime? CompletionDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CreatedDate field.
        /// </summary>
        /// <value>The CreatedDate.</value>
        public DateTime CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ExecutionDate field.
        /// </summary>
        /// <value>The ExecutionDate.</value>
        public DateTime ExecutionDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MMonitoringTypeEntity.
        /// </summary>
        /// <value>The MMonitoringTypeEntity.</value>
        public MMonitoringTypeEntity MMonitoringType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the remarks.
        /// </summary>
        /// <value>The remarks.</value>
        public String Remarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        public BizMonStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseInfoId field.
        /// </summary>
        /// <value>The SubCaseInfoId.</value>
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

            BizMonitoringInfoEntity toCompareWith = obj as BizMonitoringInfoEntity;
            return toCompareWith == null ? false : ((this.BizMonitoringInfoId == toCompareWith.BizMonitoringInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.BizMonitoringInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}