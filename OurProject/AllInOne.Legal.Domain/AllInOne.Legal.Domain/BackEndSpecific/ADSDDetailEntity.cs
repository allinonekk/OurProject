#region Header

/*****************************************************************************************************
* Description : This file represents a standard ADSDDetail entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   29/09/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: ADSDDetailEntity.cs
// Description: Represents a standard ADSDDetail entity.
// </summary>
// <copyright file= "ADSDDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;

    /// <summary>
    /// Represents a standard domain entity for ADSDDetail.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class ADSDDetailEntity : AbstractSubmissionGroup
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ADSDDetailEntity"/> class.</summary>
        public ADSDDetailEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the AD id.
        /// </summary>
        /// <value>The AD id.</value>
        public String ADId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ADSD details id.
        /// </summary>
        /// <value>The ADSD details id.</value>
        public String ADSDDetailsId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AmountAwarded field.
        /// </summary>
        /// <value>The amount awarded.</value>
        public Decimal? AmountAwarded
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Description field.
        /// </summary>
        /// <value>The description.</value>
        public String Description
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

            ADSDDetailEntity toCompareWith = obj as ADSDDetailEntity;
            return toCompareWith == null ? false : ((this.ADSDDetailsId == toCompareWith.ADSDDetailsId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ADSDDetailsId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}