#region Header

/*****************************************************************************************************
* Description : This file represents a standard MHRGType entity.
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
// File: MHRGTypeEntity.cs
// Description: Represents a standard MHRGTypeEntity entity.
// </summary>
// <copyright file= "MHRGTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MHRGTypeEntity.
    /// </summary>
    [Serializable]
    public class MHRGTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CourtInd field.
        /// </summary>
        /// <value>The court ind.</value>
        public String CourtInd
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the HeardByIndicator field.
        /// </summary>
        /// <value>The heard by indicator.</value>
        public String HeardByIndicator
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the HearingModeInd field.
        /// </summary>
        /// <value>The hearing mode ind.</value>
        public String HearingModeInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HRGTypeCode field.
        /// </summary>
        /// <value>The HRG type code.</value>
        public String HRGTypeCode
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the IsInterfaced field.
        /// </summary>
        /// <value>The is interfaced.</value>
        public String IsInterfaced
        {
            get;set;
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
            MHRGTypeEntity toCompareWith = obj as MHRGTypeEntity;
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