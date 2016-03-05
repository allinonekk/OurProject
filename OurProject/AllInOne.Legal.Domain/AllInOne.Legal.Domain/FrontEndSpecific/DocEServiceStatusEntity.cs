#region Header

/*****************************************************************************************************
* Description : This file represents a standard DocEServiceStatus entity.
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
// File: DocEServiceStatusEntity.cs
// Description: Represents a standard DocEServiceStatus entity.
// </summary>
// <copyright file= "DocEServiceStatusEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for DocEServiceStatus.
    /// It inherits from <see cref="AbstractDocId"/>
    /// </summary>
    [Serializable]
    public class DocEServiceStatusEntity : AbstractDocId, IFrontEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CreatedBy field.
        /// </summary>
        /// <value>The created by.</value>
        public String CreatedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CreatedDate field.
        /// </summary>
        /// <value>The created date.</value>
        public DateTime CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocEServiceStatusId field.
        /// </summary>
        /// <value>The doc E service status id.</value>
        public String DocEServiceStatusId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FeeAmount field.
        /// </summary>
        /// <value>The fee amount.</value>
        public Decimal? FeeAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NotificationInd field.
        /// </summary>
        /// <value>The notification ind.</value>
        public YesNo NotificationInd
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
        /// Gets or sets the ServeStatus field.
        /// </summary>
        /// <value>The serve status.</value>
        public YesNo ServeStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ServiceDate field.
        /// </summary>
        /// <value>The service date.</value>
        public DateTime? ServiceDate
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'EService.DocEServiceStatus.EServiceDetail - EService.EServiceDetail.DocEServiceStatuses (m:1)'
        /// </summary>
        /// <value>The service Id.</value>
        public String ServiceId
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

            DocEServiceStatusEntity toCompareWith = obj as DocEServiceStatusEntity;
            return toCompareWith == null ? false : ((this.DocEServiceStatusId == toCompareWith.DocEServiceStatusId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocEServiceStatusId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}