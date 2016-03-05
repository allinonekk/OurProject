#region Header

/*****************************************************************************************************
* Description : This file represents a standard ADIADetail entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   29/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: ADIADetailEntity.cs
// Description: Represents a standard ADIADetail entity.
// </summary>
// <copyright file= "ADIADetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for ADIADetail.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class ADIADetailEntity : AbstractSubmissionGroup
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ADIADetailEntity"/> class.
        /// </summary>
        public ADIADetailEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the ADIA details id.
        /// </summary>
        /// <value>The ADIA details id.</value>
        public String ADIADetailsId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ADI details id.
        /// </summary>
        /// <value>The ADI details id.</value>
        public String ADIDetailsId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AmountAwarded field.
        /// </summary>
        /// <value>The amount awarded.</value>
        public Decimal? AmountAwarded
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ADIADetail.MNatureOfInjury - Master.MNatureOfInjury.ADIADetails (m:1)'
        /// </summary>
        /// <value>The M nature of injury.</value>
        public MNatureOfInjuryEntity MNatureOfInjury
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NOIMEntry field.
        /// </summary>
        /// <value>The NOIM entry.</value>
        public String NOIMEntry
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

            ADIADetailEntity toCompareWith = obj as ADIADetailEntity;
            return toCompareWith == null ? false : ((this.ADIADetailsId == toCompareWith.ADIADetailsId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ADIADetailsId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}