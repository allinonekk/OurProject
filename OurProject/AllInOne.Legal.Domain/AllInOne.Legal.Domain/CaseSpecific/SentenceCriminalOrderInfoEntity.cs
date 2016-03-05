#region Header

/*****************************************************************************************************
* Description : This file represents a standard SentenceCriminalOrderInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   11/10/2011   		      Nithin                 	 	Created
*
*****************************************************************************************************/
// <summary>
// File: SentenceCriminalOrderInfoEntity.cs
// Description: Represents a standard SentenceCriminalOrderInfo entity.
// </summary>
// <copyright file= "SentenceCriminalOrderInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'CaseSpecific.CriminalInfo'</summary>
    [Serializable]
    public class SentenceCriminalOrderInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Gets or sets the MCriminalOrder field. </summary>
        public MCriminalOrderEntity MCriminalOrder
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MSentence field. </summary>
        public MSentenceEntity MSentence
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SentenceCriminalOrderInfoId field. </summary>
        public String SentenceCriminalOrderInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SentenceInfoId field. </summary>
        public String SentenceInfoId
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
            SentenceCriminalOrderInfoEntity toCompareWith = obj as SentenceCriminalOrderInfoEntity;
            return toCompareWith == null ? false : ((this.SentenceCriminalOrderInfoId == toCompareWith.SentenceCriminalOrderInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SentenceCriminalOrderInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}