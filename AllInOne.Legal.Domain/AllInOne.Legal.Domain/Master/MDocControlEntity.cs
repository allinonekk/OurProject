#region Header

/*****************************************************************************************************
* Description : This file represents a standard MDocCode entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   05/04/2011   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MDocControlEntity.cs
// Description: Represents a standard MDocControl entity.
// </summary>
// <copyright file= "MDocControlEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MDocControl.
    /// </summary>
    [Serializable]
    public class MDocControlEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AmendPartyInd field.
        /// </summary>
        /// <value>The AmendPartyInd.</value>
        public String AmendPartyInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the AutoAcceptInd field.
        /// </summary>
        /// <value>The AutoAcceptInd.</value>
        public String AutoAcceptInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CaseTypeCode field.
        /// </summary>
        /// <value>The CaseTypeCode.</value>
        public MCaseTypeEntity CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ComDocGroupInd field.
        /// </summary>
        /// <value>TheComDocGroupInd.</value>
        public String ComDocGroupInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the CourtInd field.
        /// </summary>
        /// <value>The CourtInd.</value>
        public MCourtTypeEntity CourtInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DIYInd field.
        /// </summary>
        /// <value>The DIYInd.</value>
        public String DIYInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocControlId field.
        /// </summary>
        /// <value>The DocControlId.</value>
        public String DocControlId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocPrefix field.
        /// </summary>
        /// <value>The DocPrefix.</value>
        public String DocPrefix
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FeeRuleCode field.
        /// </summary>
        /// <value>The FeeRuleCode.</value>
        public String FeeRuleCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the HearingInd field.
        /// </summary>
        /// <value>The HearingInd.</value>
        public String HearingInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsMandatory field.
        /// </summary>
        /// <value>The IsMandatory.</value>
        public String IsMandatory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MDocCode field.
        /// </summary>
        /// <value>The MDocCode.</value>
        public MDocCodeEntity MDocCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SpecialReqInd field.
        /// </summary>
        /// <value>The SpecialReqInd.</value>
        public String SpecialReqInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubCaseTypeCode field.
        /// </summary>
        /// <value>The SubCaseTypeCode.</value>
        public MCaseTypeEntity SubCaseTypeCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubDocGroupInd field.
        /// </summary>
        /// <value>The SubDocGroupInd.</value>
        public String SubDocGroupInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the amend fee rule code.
        /// </summary>
        /// <value>The amend fee rule code.</value>
        public string AmendFeeRuleCode
        {
            get;
            set;
        }

        public string ProcessPartyStatusUpdateInd
        {
            get;
            set;
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
            MDocControlEntity toCompareWith = obj as MDocControlEntity;
            return toCompareWith == null ? false : ((this.DocControlId == toCompareWith.DocControlId));
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
            toReturn ^= this.DocControlId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}