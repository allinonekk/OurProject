#region Header

/*****************************************************************************************************
* Description : This file represents a standard RARASInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   23/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: RARASInfoEntity.cs
// Description: Represents a standard RARASInfo entity.
// </summary>
// <copyright file= "RARASInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for RARASInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class RASInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AppealAgainstJudOrder field.
        /// </summary>
        /// <value>The appeal against jud order.</value>
        public String AppealAgainstJudOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AppealAgainstME field.
        /// </summary>
        /// <value>The appeal against ME.</value>
        public String AppealAgainstME
        {
            get;
            set;
        }

        public String AppealAgainstUserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DateofOrder field.
        /// </summary>
        /// <value>The dateof order.</value>
        public DateTime? DateofOrder
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsEOTOrderObtained field. </summary>
        public YesNo IsEOTOrderObtained
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the is LOC order obtainted.
        /// </summary>
        /// <value>The is LOC order obtainted.</value>
        public YesNo IsLOCOrderObtainted
        {
            get;
            set;
        }

        public MDesignationEntity MDesignation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RARASInfoId field.
        /// </summary>
        /// <value>The RARAS info id.</value>
        public String RASInfoId
        {
            get;
            set;
        }

        public YesNo SeekDirectionInd
        {
            get;
            set;
        }

        public MCoramEntity MCoram
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

            RASInfoEntity toCompareWith = obj as RASInfoEntity;
            return toCompareWith == null ? false : ((this.RASInfoId == toCompareWith.RASInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RASInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}