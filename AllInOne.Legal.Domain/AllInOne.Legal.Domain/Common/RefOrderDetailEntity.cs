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
    public class RefOrderDetailEntity : AbstractCaseInfoSubmissionGroup, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AdditionalDetails field.
        /// </summary>
        /// <value>The additional details.</value>
        public String AdditionalDetails
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HasObtainedLOC field.
        /// </summary>
        /// <value>The HasObtainedLOC.</value>
        public YesNo HasObtainedLOC
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
        public MDesignationEntity MDesignation
        {
            get;
            set;
        }

        public MForumTypeEntity MForumType
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the OrderCoram field.
        /// </summary>
        /// <value>The order coram.</value>
        public String OrderCoram
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OrderDate field.
        /// </summary>
        /// <value>The order date.</value>
        public DateTime? OrderDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the order made in.
        /// </summary>
        /// <value>The order made in.</value>
        public OrderMadeIn OrderMadeIn
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OrderNumber field.
        /// </summary>
        /// <value>The order number.</value>
        public String OrderNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the order.
        /// </summary>
        /// <value>The type of the order.</value>
        public OrderType OrderType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RefOrderDetailId field.
        /// </summary>
        /// <value>The ref order detail id.</value>
        public String RefOrderDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the purpose of order.
        /// </summary>
        /// <value>The purpose of order.</value>
        public PurposeOfOrder PurposeOfOrder
        {
            get;
            set;
        }

        public MCoramEntity MCoram
        {
            get;
            set;
        }

        public String JOUserId
        {
            get;
            set;
        }

        public YesNo OrderOfCourtNotshownOrderNO
        {
            get;
            set;
        }

        public string CaseNo
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

            RefOrderDetailEntity toCompareWith = obj as RefOrderDetailEntity;
            return toCompareWith == null ? false : ((this.RefOrderDetailId == toCompareWith.RefOrderDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RefOrderDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}