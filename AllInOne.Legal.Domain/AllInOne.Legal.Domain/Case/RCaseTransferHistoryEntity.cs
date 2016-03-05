#region Header

/*****************************************************************************************************
 * Description : This file represents a standard RCaseLinked.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 04/10/2010   		      Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: RCaseLinkedEntity.cs
// Description: Represents a standard RCaseLinked.
// </summary>
// <copyright file= "RCaseLinkedEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for RCaseLinked.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class RCaseTransferHistoryEntity : AbstractLastModified, ICaseEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RCaseLinkedEntity"/> class.
        /// </summary>
        public RCaseTransferHistoryEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        public string RCaseTransferHistoryId { get; set; }
        /// <summary>Gets or sets the LinkGroupId field. </summary>
        public string CaseInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LinkedDate field. </summary>
        public string FromCaseNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the LinkedDate field. </summary>
        public string ToCaseNo
        {
            get;
            set;
        }

        public TransferActionType ActionType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ObsInd field. </summary>
        public string TransferRequestedBy
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DateOfOrder field. </summary>
        public Nullable<DateTime> DateOfOrder
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

            RCaseTransferHistoryEntity toCompareWith = obj as RCaseTransferHistoryEntity;
            return toCompareWith == null ? false : (this.RCaseTransferHistoryId == toCompareWith.RCaseTransferHistoryId);
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RCaseTransferHistoryId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}