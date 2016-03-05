#region Header

/*****************************************************************************************************
 * Description : This file represents a standard entity for DocOrderDetailsEntity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 15/12/2010                 Swaroop                   Updated the entity as strongly typed.
 *****************************************************************************************************/
// <summary>
// File: DocOrderDetailsEntity.cs
// Description: Represents a standard entity for DocOrderDetailsEntity.
// </summary>
// <copyright file= "DocOrderDetailsEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for DocOrderDetailsEntity.
    /// It inherits from <see cref="AbstractCaseInfoSubCaseInfoDocId"/>
    /// </summary>
    [Serializable]
    public class DocOrderDetailsEntity : AbstractCaseInfoSubCaseInfoDocId, IDocumentEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the consent order.
        /// </summary>
        /// <value>The consent order.</value>
        public YesNo ConsentOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocOrderDetailId field.
        /// </summary>
        /// <value>The Doc Order Detail Id.</value>
        public DateTime? DateOfConsent
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocOrderDetailId field.
        /// </summary>
        /// <value>The Doc Order Detail Id.</value>
        public DateTime? DateOfOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocOrderDetailId field.
        /// </summary>
        /// <value>The Doc Order Detail Id.</value>
        public String DocOrderDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the filing from.
        /// </summary>
        /// <value>The filing from.</value>
        public FilingFrom FilingFrom
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocOrderDetailId field.
        /// </summary>
        /// <value>The Doc Order Detail Id.</value>
        public FilingOrderFor FilingOrderFor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocOrderDetailId field.
        /// </summary>
        /// <value>The Doc Order Detail Id.</value>
        public long? HRGID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocOrderDetailId field.
        /// </summary>
        /// <value>The Doc Order Detail Id.</value>
        public string IsAutoOrManual
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocOrderDetailId field.
        /// </summary>
        /// <value>The Doc Order Detail Id.</value>
        public string JudgeName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the scheduler process status.
        /// </summary>
        /// <value>The scheduler process status.</value>
        public JudgmentFor JudgmentFor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the M designation.
        /// </summary>
        /// <value>The M designation.</value>
        public MDesignationEntity MDesignation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the order for examination.
        /// </summary>
        /// <value>The order for examination.</value>
        public YesNo OrderForExamination
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocOrderDetailId field.
        /// </summary>
        /// <value>The Doc Order Detail Id.</value>
        public OrderMadeIn OrderMadeIn
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocOrderDetailId field.
        /// </summary>
        /// <value>The Doc Order Detail Id.</value>
        public string OrderNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocOrderDetailId field.
        /// </summary>
        /// <value>The Doc Order Detail Id.</value>
        public DateTime? OtherHearingDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocOrderDetailId field.
        /// </summary>
        /// <value>The Doc Order Detail Id.</value>
        public string OtherHearingMadeBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocOrderDetailId field.
        /// </summary>
        /// <value>The Doc Order Detail Id.</value>
        public YesNo PenalNotice
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocOrderDetailId field.
        /// </summary>
        /// <value>The Doc Order Detail Id.</value>
        public YesNo PrepopulateOOC
        {
            get;
            set;
        }

        /// <summary>
        /// Get or sets RecId field
        /// </summary>
        public long RecId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the req available date for other party.
        /// </summary>
        /// <value>The req available date for other party.</value>
        public DateTime? ReqAvailableDateForOtherParty
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the scheduler process status.
        /// </summary>
        /// <value>The scheduler process status.</value>
        public SchedulerProcessStatus SchedulerProcessStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocOrderDetailId field.
        /// </summary>
        /// <value>The Doc Order Detail Id.</value>
        public string WelfareOFFName
        {
            get;
            set;
        }


        public string JOUserId
        {
            get;
            set;
        }

        public string CoramCode
        {
            get;
            set;
        }

        public YesNo IsCWUOrder { get; set; }
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

            DocOrderDetailsEntity toCompareWith = obj as DocOrderDetailsEntity;
            return toCompareWith == null ? false : ((this.DocId == toCompareWith.DocOrderDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocOrderDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}