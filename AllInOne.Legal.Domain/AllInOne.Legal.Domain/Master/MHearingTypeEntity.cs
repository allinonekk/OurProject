#region Header

/*****************************************************************************************************
* Description : This file represents a standard MHearingType entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   15/02/2011  		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MDesignationEntity.cs
// Description: Represents a standard MDesignation entity.
// </summary>
// <copyright file= "MDesignationEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MHearingType.
    /// </summary>
    [Serializable]
    public class MHearingTypeEntity : AbstractMasterInfo, IMasterEntity
    {
       #region Properties


        /// <summary>
        /// Gets or sets the hearing mode ind.
        /// </summary>
        /// <value>The hearing mode ind.</value>
        public HearingModeInd HearingModeInd
        {
            get; set;
        }


        /// <summary>
        /// Gets or sets the is interfaced.
        /// </summary>
        /// <value>The is interfaced.</value>
        public YesNo IsInterfaced
        {
            get; set;
        }


        /// <summary>
        /// Gets or sets the HRG type code.
        /// </summary>
        /// <value>The HRG type code.</value>
        public String HRGTypeCode
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
            MHearingTypeEntity toCompareWith = obj as MHearingTypeEntity;
            return toCompareWith == null ? false : ((this.HRGTypeCode == toCompareWith.HRGTypeCode));
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
            toReturn ^= this.HRGTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}