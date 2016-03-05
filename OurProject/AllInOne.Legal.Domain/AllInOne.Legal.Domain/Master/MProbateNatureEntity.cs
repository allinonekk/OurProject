#region Header

/*****************************************************************************************************
* Description : This file represents a standard MProbateNature entity.
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
// File: MProbateNatureEntity.cs
// Description: Represents a standard MProbateNature entity.
// </summary>
// <copyright file= "MProbateNatureEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MProbateNatureEntity.
    /// </summary>
    [Serializable]
    public class MProbateNatureEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MProbateNature"/> class.</summary>
        public MProbateNatureEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the ChecklistID field.
        /// </summary>
        /// <value>The checklist ID.</value>
        public Int64 ChecklistID
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the PriorRightsInd field.
        /// </summary>
        /// <value>The prior rights ind.</value>
        public String PriorRightsInd
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

        /// <summary>
        /// Gets or sets the ProbateNatureGroupCode field.
        /// </summary>
        /// <value>The probate nature group code.</value>
        public String ProbateNatureGroupCode
        {
            get; set;
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
            MProbateNatureEntity toCompareWith = obj as MProbateNatureEntity;
            return toCompareWith == null ? false : ((this.ProbateNatureCode == toCompareWith.ProbateNatureCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ProbateNatureCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}