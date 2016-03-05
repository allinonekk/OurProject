#region Header

/*****************************************************************************************************
* Description : This file represents a standard MSection entity.
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
// File: MSectionEntity.cs
// Description: Represents a standard MSection entity.
// </summary>
// <copyright file= "MSectionEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MSectionEntity.
    /// </summary>
    [Serializable]
    public class MSectionEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the EndDate field.
        /// </summary>
        /// <value>The end date.</value>
        public DateTime? EndDate
        {
            get; set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Master.MSection.MCourtType - Master.MCourtType.MSections (m:1)'
        /// </summary>
        /// <value>The type of the M court.</value>
        public MCourtTypeEntity MCourtType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SectionCode field.
        /// </summary>
        /// <value>The section code.</value>
        public String SectionCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SectionDescription field.
        /// </summary>
        /// <value>The section description.</value>
        public String SectionDescription
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SectionName field.
        /// </summary>
        /// <value>The name of the section.</value>
        public String SectionName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the StartDate field.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime? StartDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the TaskRoutingType field.
        /// </summary>
        /// <value>The type of the task routing.</value>
        public String TaskRoutingType
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

            MSectionEntity toCompareWith = obj as MSectionEntity;
            return toCompareWith == null ? false : ((this.SectionCode == toCompareWith.SectionCode));
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
            toReturn ^= this.SectionCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}