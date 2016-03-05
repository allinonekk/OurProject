#region Header

/*****************************************************************************************************
* Description : This file represents a standard DrugInfo entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   20/01/2011   		      CJ                 	 	Created
*
*****************************************************************************************************/
// <summary>
// File: DrugInfoEntity.cs
// Description: Represents a standard DrugInfo entity.
// </summary>
// <copyright file= "DrugInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2011 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.CaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>Class which represents the entity 'CaseSpecific.DrugInfo'</summary>
    [Serializable]
    public class DrugInfoEntity : AbstractSubmissionGroup, ICaseSpecificEntity
    {
        #region Properties

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.DrugInfo.ChargeInfo - CaseSpecific.ChargeInfo.DrugInfos (m:1)'</summary>
        public String ChargeInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DrugAmountInGrams field. </summary>
        public String DrugAmountInGrams
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DrugInfoId field. </summary>
        public String DrugInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ItemNo field. </summary>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.DrugInfo.MDrug - Master.MDrug.DrugInfos (m:1)'</summary>
        public MDrugEntity MDrug
        {
            get;
            set;
        }

        /// <summary>Represents the navigator which is mapped onto the association 'CaseSpecific.DrugInfo.MModeOfTrafficking - Master.MModeOfTrafficking.DrugInfos (m:1)'</summary>
        public MModeOfTraffickingEntity MModeOfTrafficking
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MOTOtherText field. </summary>
        public String MOTOtherText
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the drug remarks.
        /// </summary>
        /// <value>The drug remarks.</value>
        public string DrugRemarks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MOT remarks.
        /// </summary>
        /// <value>The MOT remarks.</value>
        public string MOTRemarks
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
            DrugInfoEntity toCompareWith = obj as DrugInfoEntity;
            return toCompareWith == null ? false : ((this.DrugInfoId == toCompareWith.DrugInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DrugInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}