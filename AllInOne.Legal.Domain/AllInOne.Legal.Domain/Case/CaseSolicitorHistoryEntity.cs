#region Header

/*****************************************************************************************************
 * Description : This file represents a standard CaseSolicitorHistory.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 25/09/2010   		      Swaroop             	 	Updated
 *****************************************************************************************************/
// <summary>
// File: CaseSolicitorHistoryEntity.cs
// Description: Represents a standard CaseSolicitorHistory.
// </summary>
// <copyright file= "CaseSolicitorHistoryEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for CaseSolicitorHistory.
    /// It inherits from <see cref="AbstractCaseSolicitor"/>
    /// </summary>
    [Serializable]
    public class CaseSolicitorHistoryEntity : AbstractCaseSolicitor, ICaseEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseSolicitorHistoryEntity"/> class.
        /// </summary>
        public CaseSolicitorHistoryEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the ChangeType field.
        /// </summary>
        /// <value>The type of the change.</value>
        public String ChangeType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the EndDate field.
        /// </summary>
        /// <value>The end date.</value>
        public DateTime? EndDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime StartDate
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

            CaseSolicitorHistoryEntity toCompareWith = obj as CaseSolicitorHistoryEntity;
            return toCompareWith == null ? false : ((this.RecId == toCompareWith.RecId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RecId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}