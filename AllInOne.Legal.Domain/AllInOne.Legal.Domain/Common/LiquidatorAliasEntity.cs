#region Header

/*****************************************************************************************************
* Description : This file represents a standard LiquidatorAlias entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   01/10/2010  		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LiquidatorAliasEntity.cs
// Description: Represents a standard LiquidatorAlias entity.
// </summary>
// <copyright file= "LiquidatorAliasEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for LiquidatorAlias.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class LiquidatorAliasEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LiquidatorAliasEntity"/> class.
        /// </summary>
        public LiquidatorAliasEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the AliasName field.
        /// </summary>
        /// <value>The name of the alias.</value>
        public String AliasName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The item no.</value>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LiquidatorAliasId field.
        /// </summary>
        /// <value>The liquidator alias id.</value>
        public String LiquidatorAliasId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LiquidatorId field.
        /// </summary>
        /// <value>The liquidator id.</value>
        public String LiquidatorId
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

            LiquidatorAliasEntity toCompareWith = obj as LiquidatorAliasEntity;
            return toCompareWith == null ? false : ((this.LiquidatorAliasId == toCompareWith.LiquidatorAliasId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LiquidatorAliasId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}