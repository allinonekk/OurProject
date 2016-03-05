#region Header

/*****************************************************************************************************
* Description : This file represents a standard EServiceDetail entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   14/11/2010                 Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: EServiceDetailEntity.cs
// Description: Represents a standard EServiceDetail entity.
// </summary>
// <copyright file= "EServiceDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for EServiceDetail.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class EServiceDetailEntity : AbstractLastModified, IFrontEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AckInd field.
        /// </summary>
        /// <value>The ack ind.</value>
        public YesNo AckInd
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'EService.EServiceDetail.EServiceInfo - EService.EServiceInfo.EServiceDetails (m:1)'
        /// </summary>
        /// <value>The E service info id.</value>
        public String EServiceInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'EService.EServiceDetail.MServiceType - Master.MServiceType.EServiceDetails (m:1)'
        /// </summary>
        /// <value>The type of the M service.</value>
        public MServiceTypeEntity MServiceType
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
        /// Gets or sets the PreferredDate field.
        /// </summary>
        /// <value>The preferred date.</value>
        public DateTime? PreferredDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the ServiceId field.
        /// </summary>
        /// <value>The service id.</value>
        public Int64 ServiceId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ToBeServedLFID field.
        /// </summary>
        /// <value>To be served LFID.</value>
        public String ToBeServedLFID
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

            EServiceDetailEntity toCompareWith = obj as EServiceDetailEntity;
            return toCompareWith == null ? false : ((this.ServiceId == toCompareWith.ServiceId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ServiceId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}