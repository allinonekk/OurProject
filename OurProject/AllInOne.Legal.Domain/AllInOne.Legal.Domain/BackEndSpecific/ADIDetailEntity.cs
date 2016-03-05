#region Header

/*****************************************************************************************************
* Description : This file represents a standard ADIDetail entity.
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
// File: ADIDetailEntity.cs
// Description: Represents a standard ADIDetail entity.
// </summary>
// <copyright file= "ADIDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for ADIDetail.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class ADIDetailEntity : AbstractSubmissionGroup
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ADIDetailEntity"/> class.
        /// </summary>
        public ADIDetailEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ADIADetail.ADIDetail - Common.ADIDetail.ADIADetails (m:1)'
        /// </summary>
        /// <value>The ADIA details.</value>
        public List<ADIADetailEntity> ADIADetails
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ADIDetail.AssessmentDamage - Common.AssessmentDamage.ADIDetails (m:1)'
        /// </summary>
        /// <value>The assessment damage.</value>
        public string ADId
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
        /// Gets or sets the Description field.
        /// </summary>
        /// <value>The description.</value>
        public String Description
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.ADIDetail.MBodyPart - Master.MBodyPart.ADIDetails (m:1)'
        /// </summary>
        /// <value>The M body part.</value>
        public MBodyPartEntity MBodyPart
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

            ADIDetailEntity toCompareWith = obj as ADIDetailEntity;
            return toCompareWith == null ? false : ((this.ADIDetailsId == toCompareWith.ADIDetailsId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ADIDetailsId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}