#region Header

/*****************************************************************************************************
* Description : This file represents a standard MRulesOfCourtOrder entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   05/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MRulesOfCourtOrderEntity.cs
// Description: Represents a standard MRulesOfCourtOrder entity.
// </summary>
// <copyright file= "MRulesOfCourtOrderEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MRulesOfCourtOrder.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class MRulesOfCourtOrderEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MRulesOfCourtOrderEntity"/> class.
        /// </summary>
        public MRulesOfCourtOrderEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        public Decimal Amount
        {
            get; set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Master.MRulesOfCourtOrder.MForumType - Master.MForumType.MRulesOfCourtOrders (m:1)'
        /// </summary>
        /// <value>The type of the M forum.</value>
        public MForumTypeEntity MForumType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the order no.
        /// </summary>
        /// <value>The order no.</value>
        public String OrderNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the ClaimLevel field.
        /// </summary>
        /// <value>The claim level.</value>
        public PaymentInReasonType PaymentInReason
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the rule no.
        /// </summary>
        /// <value>The rule no.</value>
        public String RuleNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the rule order code.
        /// </summary>
        /// <value>The rule order code.</value>
        public String RuleOrderCode
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
            if(obj == null)
            {
                return false;
            }

            MRulesOfCourtOrderEntity toCompareWith = obj as MRulesOfCourtOrderEntity;
            return toCompareWith == null ? false : ((this.RuleOrderCode == toCompareWith.RuleOrderCode));
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
            toReturn ^= this.RuleOrderCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}