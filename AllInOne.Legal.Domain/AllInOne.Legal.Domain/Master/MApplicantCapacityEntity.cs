#region Header

/*****************************************************************************************************
* Description : This file represents a standard MApplicantCapacity entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MApplicantCapacityEntity.cs
// Description: Represents a standard MApplicantCapacity entity.
// </summary>
// <copyright file= "MApplicantCapacityEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MApplicantCapacity.
    /// </summary>
    [Serializable]
    public class MApplicantCapacityEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MApplicantCapacity"/> class.
        /// </summary>
        public MApplicantCapacityEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the ApplicantCapacityCode field.
        /// </summary>
        /// <value>The applicant capacity code.</value>
        public String ApplicantCapacityCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ProbateNatureCode field.
        /// </summary>
        /// <value>The probate nature code.</value>
        public String ProbateNatureCode
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
            MApplicantCapacityEntity toCompareWith = obj as MApplicantCapacityEntity;
            return toCompareWith == null ? false : ((this.ApplicantCapacityCode == toCompareWith.ApplicantCapacityCode));
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
            toReturn ^= this.ApplicantCapacityCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}