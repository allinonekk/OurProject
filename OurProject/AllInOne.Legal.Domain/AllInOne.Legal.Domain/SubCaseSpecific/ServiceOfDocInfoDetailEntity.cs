#region Header

/*****************************************************************************************************
* Description : This file represents a standard ServiceOfDocInfoDetail entity.
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
// File: ServiceOfDocInfoDetailEntity.cs
// Description: Represents a standard ServiceOfDocInfoDetail entity.
// </summary>
// <copyright file= "ServiceOfDocInfoDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCaseSpecific
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for ServiceOfDocInfoDetail.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class ServiceOfDocInfoDetailEntity : AbstractLastModified, ISubCaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Addr1 field.
        /// </summary>
        /// <value>The addr1.</value>
        public String Addr1
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Addr2 field.
        /// </summary>
        /// <value>The addr2.</value>
        public String Addr2
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Addr3 field.
        /// </summary>
        /// <value>The addr3.</value>
        public String Addr3
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Addr4 field.
        /// </summary>
        /// <value>The addr4.</value>
        public String Addr4
        {
            get;
            set;
        }

        public String City
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
        /// Gets or sets the item no.
        /// </summary>
        /// <value>The item no.</value>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ServiceOfDocDocument.ServiceOfDocInfoDetail - Common.ServiceOfDocInfoDetail.ServiceOfDocDocuments (m:1)'
        /// </summary>
        /// <value>The service of doc documents.</value>
        public List<ServiceOfDocDocumentEntity> ListServiceOfDocDocumentEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the M country.
        /// </summary>
        /// <value>The M country.</value>
        public MCountryEntity MCountry
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
        /// Gets or sets the PostalCode field.
        /// </summary>
        /// <value>The postal code.</value>
        public String PostalCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the service of doc info detail id.
        /// </summary>
        /// <value>The service of doc info detail id.</value>
        public String ServiceOfDocInfoDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ServiceOfDocInfoDetail.ServiceOfDocInfo - Common.ServiceOfDocInfo.ServiceOfDocInfoDetails (m:1)'
        /// </summary>
        /// <value>The service of doc info Id.</value>
        public String ServiceOfDocInfoId
        {
            get;
            set;
        }

        public String State
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ServiceOfDocInfoDetail.CaseParty - Case.CaseParty.ServiceOfDocInfoDetails (m:1)'
        /// </summary>
        /// <value>To be servied CPID.</value>
        public String ToBeServiedCPID
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

            ServiceOfDocInfoDetailEntity toCompareWith = obj as ServiceOfDocInfoDetailEntity;
            return toCompareWith == null ? false : ((this.ServiceOfDocInfoDetailId == toCompareWith.ServiceOfDocInfoDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ServiceOfDocInfoDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}