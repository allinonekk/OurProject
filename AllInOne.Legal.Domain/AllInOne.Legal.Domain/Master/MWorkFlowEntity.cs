#region Header

/*****************************************************************************************************
* Description : This file represents a standard MWorkFlow entity.
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
// File: MWorkFlowEntity.cs
// Description: Represents a standard MWorkFlow entity.
// </summary>
// <copyright file= "MWorkFlowEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MWorkFlowEntity.
    /// </summary>
    [Serializable]
    public class MWorkFlowEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MWorkFlow"/> class.
        /// </summary>
        public MWorkFlowEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the WFName field.
        /// </summary>
        /// <value>The name of the WF.</value>
        public String WFName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the WFType field.
        /// </summary>
        /// <value>The type of the WF.</value>
        public String WFType
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
            MWorkFlowEntity toCompareWith = obj as MWorkFlowEntity;
            return toCompareWith == null ? false : ((this.WFType == toCompareWith.WFType));
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
            toReturn ^= this.WFType.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}