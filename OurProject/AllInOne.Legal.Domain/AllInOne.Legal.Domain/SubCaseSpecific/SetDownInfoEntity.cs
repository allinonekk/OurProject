#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for SetDownInfo.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   19/12/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: SetDownInfoEntity.cs
// Description: Represents a standard domain entity for SetDownInfo.
// </summary>
// <copyright file= "SetDownInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.SubCaseSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for SetDownInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class SetDownInfoEntity : AbstractSubmissionGroup, ISubCaseSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the IsCertExcAEICFiled field.
        /// </summary>
        /// <value>The is cert exc AEIC filed.</value>
        public YesNo IsCertExcAEICFiled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsHearingFeePayable field.
        /// </summary>
        /// <value>The is hearing fee payable.</value>
        public YesNo IsHearingFeePayable
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsOrder25R8Complied field.
        /// </summary>
        /// <value>The is order25 r8 complied.</value>
        public YesNo IsOrder25R8Complied
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NoOfHRGDays field.
        /// </summary>
        /// <value>The no of HRG days.</value>
        public Int32? NoOfHRGDays
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SDPursuantTo field.
        /// </summary>
        /// <value>The SD pursuant to.</value>
        public SetDownPursuantTo SDPursuantTo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SetDownId field.
        /// </summary>
        /// <value>The set down id.</value>
        public String SetDownId
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

            SetDownInfoEntity toCompareWith = obj as SetDownInfoEntity;
            return toCompareWith == null ? false : ((this.SetDownId == toCompareWith.SetDownId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SetDownId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}