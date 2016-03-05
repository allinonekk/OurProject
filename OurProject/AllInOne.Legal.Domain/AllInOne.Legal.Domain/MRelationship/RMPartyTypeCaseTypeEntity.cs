#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMDocCodeHrgType entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   06/04/2011   		      Nithin             	 	    Created
*
*****************************************************************************************************/
// <summary>
// File: RMDocCodeHrgTypeEntity.cs
// Description: Represents a standard RMDocCodeHrgType entity.
// </summary>
// <copyright file= "RMDocCodeHrgTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.MRelationship
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>Class which represents the entity 'Master.RMPartyTypeCaseTypeEntity'</summary>
    [Serializable]
    public class RMPartyTypeCaseTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public String CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the PartyTypeCode field. </summary>
        public String PartyTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsInterfaced field. </summary>
        public YesNo IsInterfaced
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ComTypeInd field. </summary>
        public YesNo ComTypeInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGTypeCode field. </summary>
        public Int32 SeqNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsInterfaced field. </summary>
        public PartyFlippingCategory PartyFlippingCategory
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
            RMPartyTypeCaseTypeEntity toCompareWith = obj as RMPartyTypeCaseTypeEntity;
            return toCompareWith == null ? false : ((this.CaseTypeCode == toCompareWith.CaseTypeCode)
                && (this.PartyTypeCode == toCompareWith.PartyTypeCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseTypeCode.GetHashCode();
            toReturn ^= this.PartyTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}