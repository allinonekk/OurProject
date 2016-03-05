#region Header

/*****************************************************************************************************
* Description : This file represents a standard MChecklist entity.
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
// File: MChecklistEntity.cs
// Description: Represents a standard MChecklist entity.
// </summary>
// <copyright file= "MChecklistEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MChecklist.
    /// </summary>
    [Serializable]
    public class MChecklistEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MChecklist"/> class.
        /// </summary>
        public MChecklistEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the CaseType field.
        /// </summary>
        /// <value>The type of the case.</value>
        public String CaseType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the check list id.
        /// </summary>
        /// <value>The check list id.</value>
        public Int64 CheckListId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the EffectiveFromDate field.
        /// </summary>
        /// <value>The effective from date.</value>
        public DateTime? EffectiveFromDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the EffectiveToDate field.
        /// </summary>
        /// <value>The effective to date.</value>
        public DateTime? EffectiveToDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Name field.
        /// </summary>
        /// <value>The name.</value>
        public String Name
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Notes field.
        /// </summary>
        /// <value>The notes.</value>
        public String Notes
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the StageDescription field.
        /// </summary>
        /// <value>The stage description.</value>
        public String StageDescription
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the TotalStages field.
        /// </summary>
        /// <value>The total stages.</value>
        public Int32? TotalStages
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
            if (obj == null)
            {
                return false;
            }
            MChecklistEntity toCompareWith = obj as MChecklistEntity;
            return toCompareWith == null ? false : ((this.CheckListId == toCompareWith.CheckListId));
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
            toReturn ^= this.CheckListId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}