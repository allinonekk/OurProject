#region Header

/*****************************************************************************************************
* Description : This file represents a standard RMCDRAutoFixTimeLine entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   29/01/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: RMCDRAutoFixTimeLineEntity.cs
// Description: Represents a standard RMCDRAutoFixTimeLine entity.
// </summary>
// <copyright file= "RMCDRAutoFixTimeLine.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.BackEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for RMCDRAutoFixTimeLine.
    /// </summary>
    [Serializable]
    public class RMCDRAutoFixTimeLineEntity : AbstractLastModified, IBackEndSpecificEntity
    {
        #region Properties

        public MCaseTypeEntity CaseTypeCode
        {
            get;
            set;
        }

        public MDocCodeEntity DocCode
        {
            get;
            set;
        }

        public MNOCEntity NOCCode
        {
            get;
            set;
        }

        public String QuantumType
        {
            get;
            set;
        }

        public Decimal? QuantumValue
        {
            get;
            set;
        }

        public Int32 TimeLineDays
        {
            get;
            set;
        }

        public YesNo ObsInd
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
            RMCDRAutoFixTimeLineEntity toCompareWith = obj as RMCDRAutoFixTimeLineEntity;
            return toCompareWith == null ? false : ((this.CaseTypeCode == toCompareWith.CaseTypeCode) && (this.DocCode == toCompareWith.DocCode) && (this.NOCCode == toCompareWith.NOCCode));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CaseTypeCode.GetHashCode();
            toReturn ^= this.DocCode.GetHashCode();
            toReturn ^= this.NOCCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}