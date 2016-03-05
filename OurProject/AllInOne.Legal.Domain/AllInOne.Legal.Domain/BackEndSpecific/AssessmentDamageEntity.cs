#region Header

/*****************************************************************************************************
* Description : This file represents a standard AssessmentDamage entity.
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
// File: AssessmentDamageEntity.cs
// Description: Represents a standard AssessmentDamage entity.
// </summary>
// <copyright file= "AssessmentDamageEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for AssessmentDamage.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class AssessmentDamageEntity : AbstractLastModified,IBackEndSpecificEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentDamageEntity"/> class.
        /// </summary>
        public AssessmentDamageEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the AD id.
        /// </summary>
        /// <value>The AD id.</value>
        public String ADId
        {
            get;
            set;
        }


        public DateTime? AwardDate
        {

            get;
            set;
        }

        public YesNo IsDependencyClaimed
        {

            get;
            set;
        }

        public String Coram
        {

            get;
            set;
        }

        public Int32? PartyAge
        {

            get;
            set;
        }

        public Int32? Multiplier
        {

            get;
            set;
        }

        public Decimal? LOFEAmountAwarded
        {

            get;
            set;
        }

        public Decimal? PSAmountAwarded
        {

            get;
            set;
        }

        public Decimal? LOAAmountAwarded
        {

            get;
            set;
        }

        public Decimal? LOELAmountAwarded
        {

            get;
            set;
        }

        public Decimal? TGenDamAwarded
        {

            get;
            set;
        }

        public String Comments
        {
            get;
            set;
        }


        public String CasePartyId
        {
            get;
            set;
        }

        public Int64 SubCaseInfoId
        {
            get;
            set;
        }

        public Decimal? LOECAmountAwarded
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

            AssessmentDamageEntity toCompareWith = obj as AssessmentDamageEntity;
            return toCompareWith == null ? false : ((this.ADId == toCompareWith.ADId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ADId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}