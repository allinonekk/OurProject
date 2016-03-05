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

    /// <summary>Class which represents the entity 'Master.RMNOAForumHrgTypeEntity'</summary>
    [Serializable]
    public class RMDocCodeHrgTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public String CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DocCode field. </summary>
        public String DocCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the EndorsementType field. </summary>
        public EndorsementType EndorsementType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HeardByInd field. </summary>
        public String HeardByInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HeardIn field. </summary>
        public String HeardIn
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGTypeCode field. </summary>
        public String HRGTypeCode
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

        /// <summary>Gets or sets the LatencyAllowed field. </summary>
        public Int32? LatencyAllowed
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MaxDay field. </summary>
        public Int32? MaxDay
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MinDay field. </summary>
        public Int32? MinDay
        {
            get;
            set;
        }

        /// <summary>Gets or sets the MSWorkitem field. </summary>
        public String MSWorkitem
        {
            get;
            set;
        }

        /// <summary>Gets or sets the HRGTypeCode field. </summary>
        public YesNo ROCInd
        {
            get;
            set;
        }

        /// <summary>Gets or sets the UsedInAutoFix field. </summary>
        public YesNo UsedInAutoFix
        {
            get;
            set;
        }

        /// <summary>Gets or sets the WeekEndInd field. </summary>
        public YesNo WeekEndInd
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
            RMDocCodeHrgTypeEntity toCompareWith = obj as RMDocCodeHrgTypeEntity;
            return toCompareWith == null ? false : ((this.DocCode == toCompareWith.DocCode) && (this.HRGTypeCode == toCompareWith.HRGTypeCode) && (this.CaseTypeCode==toCompareWith.CaseTypeCode)&&(this.EndorsementType==toCompareWith.EndorsementType));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocCode.GetHashCode();
            toReturn ^= this.CaseTypeCode.GetHashCode();
            toReturn ^= this.HRGTypeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}