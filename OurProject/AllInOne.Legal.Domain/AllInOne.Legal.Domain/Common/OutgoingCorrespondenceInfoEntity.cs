#region Header

/*****************************************************************************************************
 * Description : This file represents a standard OtherITMO.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 25/09/2010   		      Swaroop             	 	Updated
 *****************************************************************************************************/
// <summary>
// File: OtherITMOEntity.cs
// Description: Represents a standard OtherITMO.
// </summary>
// <copyright file= "OtherITMOEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for OutgoingCorrespondenceInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class OutgoingCorrespondenceInfoEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherITMOEntity"/> class.
        /// </summary>
        public OutgoingCorrespondenceInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the FeePayable field.
        /// </summary>
        /// <value>The Fee Payable.</value>
        public Decimal? FeePayable
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SeqNo field.
        /// </summary>
        /// <value>The seq no.</value>
        public DateTime? HearingDate
        {
            get;
            set;
        }

        public InterfaceStatus IsInterfaced
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OtherITMOId field.
        /// </summary>
        /// <value>The other ITMO id.</value>
        public String OutgoingCorrespondenceInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The item no.</value>
        public DateTime? TaxedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CollectionDate field.
        /// </summary>
        /// <value>The Collection Date.</value>
        public DateTime? CollectionDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CollectedAmount field.
        /// </summary>
        /// <value>The Collected Amount.</value>
        public Decimal? CollectedAmount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocCollectPeriod field.
        /// </summary>
        /// <value>The  DocCollect Period.</value>
        public String DocCollectPeriod
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CollectedBy field.
        /// </summary>
        /// <value>The Collected By.</value>
        public String CollectedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CollectionRemarks field.
        /// </summary>
        /// <value>The Collection Remarks .</value>
        public String CollectionRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BatchNo field.
        /// </summary>
        /// <value>The Batch No .</value>
        public String BatchNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PaymenttxnNo field.
        /// </summary>
        /// <value>The Payment transaction No .</value>
        public String PaymenttxnNo
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

            OutgoingCorrespondenceInfoEntity toCompareWith = obj as OutgoingCorrespondenceInfoEntity;
            return toCompareWith == null ? false : ((this.OutgoingCorrespondenceInfoId == toCompareWith.OutgoingCorrespondenceInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.OutgoingCorrespondenceInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}