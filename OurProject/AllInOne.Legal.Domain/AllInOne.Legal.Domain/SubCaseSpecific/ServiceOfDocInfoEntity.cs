#region Header

/*****************************************************************************************************
* Description : This file represents a standard ServiceOfDocInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: ServiceOfDocInfoEntity.cs
// Description: Represents a standard ServiceOfDocInfo entity.
// </summary>
// <copyright file= "ServiceOfDocInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for ServiceOfDocInfo.
    /// It inherits from <see cref="AbstractCaseInfoSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class ServiceOfDocInfoEntity : AbstractCaseInfoSubmissionGroup, ISubCaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the MFARefNo field.
        /// </summary>
        /// <value>The MFA ref no.</value>
        public String MFARefNo
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ServiceOfDocInfo.MServeStatu - Master.MServeStatus.ServiceOfDocInfos (m:1)'
        /// </summary>
        /// <value>The M serve status.</value>
        public MServeStatusEntity MServeStatus
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
        /// Gets or sets the ref order detail id.
        /// </summary>
        /// <value>The ref order detail id.</value>
        public String RefOrderDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RequestDate field.
        /// </summary>
        /// <value>The request date.</value>
        public DateTime RequestDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RequestId field.
        /// </summary>
        /// <value>The request id.</value>
        public String RequestId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the service date.
        /// </summary>
        /// <value>The service date.</value>
        public DateTime? ServiceDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ServiceOfDocInfoId field.
        /// </summary>
        /// <value>The service of doc info id.</value>
        public String ServiceOfDocInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ServiceSatus field.
        /// </summary>
        /// <value>The service satus.</value>
        public ServiceStatus ServiceStatus
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

            ServiceOfDocInfoEntity toCompareWith = obj as ServiceOfDocInfoEntity;
            return toCompareWith == null ? false : ((this.ServiceOfDocInfoId == toCompareWith.ServiceOfDocInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ServiceOfDocInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}