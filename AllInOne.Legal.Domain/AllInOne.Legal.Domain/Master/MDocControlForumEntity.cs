#region Header

/*****************************************************************************************************
* Description : This file represents a standard MDocControlForum entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   03/10/2014   		      Aaron             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MDocControlForumEntity.cs
// Description: Represents a standard MDocControlForum entity.
// </summary>
// <copyright file= "MDocControlForumEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2014 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MDocControlForum.
    /// </summary>
    [Serializable]
    public class MDocControlForumEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        public string ForumId { get; set; }
        public MDocCodeEntity MDocCode { get; set; }
        public MCaseTypeEntity CaseTypeCode { get; set; }
        public string DocPrefix { get; set; }
        public YesNo DIYInd { get; set; }
        public YesNo HearingInd { get; set; }
        public YesNo AutoAcceptInd { get; set; }
        public YesNo SpecialReqInd { get; set; }
        public YesNo ComDocGroupInd { get; set; }
        public YesNo SubDocGroupInd { get; set; }
        public YesNo IsMandatory { get; set; }
        public YesNo AmendPartyInd { get; set; }
        public string FeeRuleCode { get; set; }
        public string DocControlId { get; set; }
        public MCaseTypeEntity SubCaseTypeCode { get; set; }
        public string AmendFeeRuleCode { get; set; }
        public YesNo ProcessPartyStatusUpdateInd { get; set; }

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