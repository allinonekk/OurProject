#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for RefOrderDetail.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   03/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: RefOrderDetailEntity.cs
// Description: Represents a standard domain entity for RefOrderDetail.
// </summary>
// <copyright file= "RefOrderDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for RefOrderDetail.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class RefOrderJOInfoEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AdditionalDetails field.
        /// </summary>
        /// <value>The additional details.</value>
        public string RefOrderJOInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HasObtainedLOC field.
        /// </summary>
        /// <value>The HasObtainedLOC.</value>
        public string JOUserId
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
        /// Represents the navigator which is mapped onto the association 'Document.RefOrderDetail.MDesignation - Master.MDesignation.RefOrderDetails (m:1)'
        /// </summary>
        /// <value>The M designation.</value>
        public MCoramEntity MCoram
        {
            get;
            set;
        }

        public MDesignationEntity MDesignation
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the OrderCoram field.
        /// </summary>
        /// <value>The order coram.</value>
        public string JudgeName
        {
            get;
            set;
        }

        public string RefOrderDetailId
        {
            get;
            set;
        }

        public string DocOrderDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets OrderType
        /// </summary>
        public OrderType OrderType
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
            if (obj == null)
            {
                return false;
            }

            RefOrderJOInfoEntity toCompareWith = obj as RefOrderJOInfoEntity;
            return toCompareWith == null ? false : ((this.RefOrderJOInfoId == toCompareWith.RefOrderJOInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RefOrderJOInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}