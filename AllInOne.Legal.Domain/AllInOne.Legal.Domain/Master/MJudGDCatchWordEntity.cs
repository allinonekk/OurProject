#region Header

/*****************************************************************************************************
* Description : This file represents a standard MJudGDCatchWord entity.
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
// File: MJudGDCatchWordEntity.cs
// Description: Represents a standard MJudGDCatchWordEntity entity.
// </summary>
// <copyright file= "MJudGDCatchWordEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MJudGDCatchWordEntity.
    /// </summary>
    [Serializable]
    public class MJudGDCatchWordEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MJudGDCatchWord"/> class.
        /// </summary>
        public MJudGDCatchWordEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the Display field.
        /// </summary>
        /// <value>The display.</value>
        public String Display
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the JudCatchWordID field.
        /// </summary>
        /// <value>The jud catch word ID.</value>
        public Int64 JudCatchWordID
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the Level field.
        /// </summary>
        /// <value>The level.</value>
        public Int32 Level
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ParentRef field.
        /// </summary>
        /// <value>The parent ref.</value>
        public Int64 ParentRef
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
            MJudGDCatchWordEntity toCompareWith = obj as MJudGDCatchWordEntity;
            return toCompareWith == null ? false : ((this.JudCatchWordID == toCompareWith.JudCatchWordID));
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
            toReturn ^= this.JudCatchWordID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}