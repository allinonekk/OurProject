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
    public class OutgoingCorrespondenceCourtFeeEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherITMOEntity"/> class.
        /// </summary>
        public OutgoingCorrespondenceCourtFeeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The item no.</value>
        public Int32? ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OtherText field.
        /// </summary>
        /// <value>The other text.</value>
        public String OriginalDocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OtherITMOId field.
        /// </summary>
        /// <value>The other ITMO id.</value>
        public String OutgoingCorrespondenceCourtFeeId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SeqNo field.
        /// </summary>
        /// <value>The seq no.</value>
        public Decimal? ShortFallAmount
        {
            get;
            set;
        }

        public Decimal? ShortFallDocumentFee 
        {
            get;
            set;
        }

        public Decimal? ShortFallProcessingFee 
        {
            get;
            set;
        }

        public Decimal? ShortFallTransmissionFee 
        {
            get;
            set;
        }

        public Decimal? ShortFallUrgentFee  
        {
            get;
            set;
        }

        public Decimal? ShortFallServiceBureauFee 
        {
            get;
            set;
        }

        public Decimal? CollectedAmount
        {
            get;
            set;
        }

        public System.DateTime? CollectionDate
        {
            get;
            set;
        }

        public String CollectedBy
        {
            get;
            set;
        }

        public String CollectionRemarks
        {
            get;
            set;
        }

        public String BatchNo
        {
            get;
            set;
        }

        public String PaymenttxnNo
        {
            get;
            set;
        }

        public InterfaceStatus IsNBSInterfaced
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

            OutgoingCorrespondenceCourtFeeEntity toCompareWith = obj as OutgoingCorrespondenceCourtFeeEntity;
            return toCompareWith == null ? false : ((this.OutgoingCorrespondenceCourtFeeId == toCompareWith.OutgoingCorrespondenceCourtFeeId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.OutgoingCorrespondenceCourtFeeId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}