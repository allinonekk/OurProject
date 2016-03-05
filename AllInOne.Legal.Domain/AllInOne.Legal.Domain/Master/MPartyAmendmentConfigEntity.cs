#region Header

/*****************************************************************************************************
* Description : This file represents a standard MPartyAmendmentConfig entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   26/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MPartyAmendmentConfigEntity.cs
// Description: Represents a standard MPartyAmendmentConfig entity.
// </summary>
// <copyright file= "MPartyAmendmentConfigEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MPartyAmendmentConfigEntity.
    /// </summary>
    [Serializable]
    public class MPartyAmendmentConfigEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MPartyAmendmentConfig"/> class.
        /// </summary>
        public MPartyAmendmentConfigEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the AmendmentAt field.
        /// </summary>
        /// <value>The amendment at.</value>
        public String AmendmentAt
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the AmendmentConfigID field.
        /// </summary>
        /// <value>The amendment config id.</value>
        public String AmendmentConfigId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ConfigXML field.
        /// </summary>
        /// <value>The config XML.</value>
        public String ConfigXML
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the IsAmendmentApplicable field.
        /// </summary>
        /// <value>The is amendment applicable.</value>
        public String IsAmendmentApplicable
        {
            get; set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Master.MPartyAmendmentConfig.MCaseType - Master.MCaseType.MPartyAmendmentConfigs (m:1)'
        /// </summary>
        /// <value>The type of the M case.</value>
        public MCaseTypeEntity MCaseType
        {
            get; set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            MPartyAmendmentConfigEntity toCompareWith = obj as MPartyAmendmentConfigEntity;
            return toCompareWith == null ? false : ((this.AmendmentConfigId == toCompareWith.AmendmentConfigId));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AmendmentConfigId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}