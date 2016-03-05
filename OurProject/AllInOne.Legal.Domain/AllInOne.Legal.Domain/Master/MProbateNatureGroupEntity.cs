#region Header

/*****************************************************************************************************
* Description : This file represents a standard MProbateNatureGroup entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   29/06/2011   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MProbateNatureEntity.cs
// Description: Represents a standard MProbateNatureGroup entity.
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
    /// Represents a standard domain entity for MProbateNatureGroupEntity.
    /// </summary>
    [Serializable]
    public class MProbateNatureGroupEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MProbateNature"/> class.</summary>
        public MProbateNatureGroupEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public YesNo IsInterfaced
        {
            get;
            set;
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
            MProbateNatureGroupEntity toCompareWith = obj as MProbateNatureGroupEntity;
            return toCompareWith == null ? false : ((this.ProbateNatureGroupCode == toCompareWith.ProbateNatureGroupCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ProbateNatureGroupCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}