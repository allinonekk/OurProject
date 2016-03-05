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

namespace AllInOne.Legal.Entities.BackEnd
{
    using System;


    /// <summary>
    /// Represents a standard domain entity for RefOrderDetail.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class RefOrderJOInfo: ICommon
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AdditionalDetails field.
        /// </summary>
        /// <value>The additional details.</value>
        public virtual string RefOrderJOInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the JOUserId field.
        /// </summary>
        /// <value>The JOUserId.</value>
        public virtual string JOUserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The item no.</value>
        public virtual Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Document.RefOrderJOInfo.MCoram - Master.MCoram.RefOrderJOInfo (m:1)'
        /// </summary>
        /// <value>The MCoram.</value>
        public virtual MCoram MCoram
        {
            get;
            set;
        }

        public virtual MDesignation MDesignation
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the OrderCoram field.
        /// </summary>
        /// <value>The order coram.</value>
        public virtual string JudgeName
        {
            get;
            set;
        }

        public virtual string SubmissionGroupID
        {
            get;
            set;
        }
        /// <summary>Gets or sets the LastModifiedBy field. </summary>
        public virtual string LastModifiedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LastModifiedDate field. </summary>
        public virtual DateTime LastModifiedDate
        {
            get;
            set;
        }

        public virtual string RefOrderDetailId
        {
            get;
            set;
        }

        public virtual string DocOrderDetailId
        {
            get;
            set;
        }

        public virtual string OrderType
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

            RefOrderJOInfo toCompareWith = obj as RefOrderJOInfo;
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