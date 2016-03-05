#region Header

/*****************************************************************************************************
* Description : This file represents a standard LiquidatorPIC entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   01/10/2010  		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LiquidatorPICEntity.cs
// Description: Represents a standard LiquidatorPIC entity.
// </summary>
// <copyright file= "LiquidatorPICEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for LiquidatorPIC.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class LiquidatorPICEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LiquidatorPICEntity"/> class.
        /// </summary>
        public LiquidatorPICEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the AddressAvailabilityInd field.
        /// </summary>
        /// <value>The address availability ind.</value>
        public AddressAvailabilityType AddressAvailabilityInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AICRemarks field.
        /// </summary>
        /// <value>The AIC remarks.</value>
        public String AICRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FormerName field.
        /// </summary>
        /// <value>The name of the former.</value>
        public String FormerName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FullName field.
        /// </summary>
        /// <value>The full name.</value>
        public String FullName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdNumber field.
        /// </summary>
        /// <value>The id number.</value>
        public String IdNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IdRemarks field.
        /// </summary>
        /// <value>The id remarks.</value>
        public String IdRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LiquidatorId field.
        /// </summary>
        /// <value>The liquidator id.</value>
        public String LiquidatorId
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CWU.LiquidatorPICAddress.LiquidatorPIC - CWU.LiquidatorPIC.LiquidatorPICAddresses (m:1)'
        /// </summary>
        /// <value>The liquidator PIC addresses.</value>
        public List<LiquidatorPICAddressEntity> LiquidatorPICAddresses
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CWU.LiquidatorPICAlias.LiquidatorPIC - CWU.LiquidatorPIC.LiquidatorPICAliases (m:1)'
        /// </summary>
        /// <value>The liquidator PIC aliases.</value>
        public List<LiquidatorPICAliasEntity> LiquidatorPICAliases
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LiquidatorPICId field.
        /// </summary>
        /// <value>The liquidator PIC id.</value>
        public String LiquidatorPICId
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CWU.LiquidatorPIC.MActingInCapacity - Master.MActingInCapacity.LiquidatorPICs (m:1)'</summary>
        public MActingInCapacityEntity MActingInCapacity
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CWU.LiquidatorPIC.MCountry - Master.MCountry.LiquidatorPICs (m:1)'
        /// </summary>
        /// <value>The M country.</value>
        public MCountryEntity MCountry
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the M entity.
        /// </summary>
        /// <value>The type of the M entity.</value>
        public MEntityTypeEntity MEntityType
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CWU.LiquidatorPIC.MGender - Master.MGender.LiquidatorPICs (m:1)'
        /// </summary>
        /// <value>The M gender.</value>
        public MGenderEntity MGender
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CWU.LiquidatorPIC.MPersonIDGroup - Master.MPersonIDGroup.LiquidatorPICs (m:1)'
        /// </summary>
        /// <value>The M person ID group.</value>
        public MPersonIDGroupEntity MPersonIdGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'CWU.LiquidatorPIC.MPersonIDType - Master.MPersonIDType.LiquidatorPICs (m:1)'
        /// </summary>
        /// <value>The type of the M person ID.</value>
        public MPersonIDTypeEntity MPersonIdType
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

            LiquidatorPICEntity toCompareWith = obj as LiquidatorPICEntity;
            return toCompareWith == null ? false : ((this.LiquidatorPICId == toCompareWith.LiquidatorPICId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LiquidatorPICId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}