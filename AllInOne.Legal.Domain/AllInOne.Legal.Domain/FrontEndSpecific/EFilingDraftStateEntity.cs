#region Header

/*****************************************************************************************************
* Description : This file represents a standard EFilingDraftState entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   12/11/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: EFilingDraftStateEntity.cs
// Description: Represents a standard EFilingDraftState entity.
// </summary>
// <copyright file= "EFilingDraftStateEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for EFilingDraftState.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class EFilingDraftStateEntity : AbstractCaseInfo, IFrontEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the EFilingDraftStateId field.
        /// </summary>
        /// <value>The E filing draft state id.</value>
        public String EFilingDraftStateId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FilingType field.
        /// </summary>
        /// <value>The type of the filing.</value>
        public String FilingType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ObsInd field.
        /// </summary>
        /// <value>The obs ind.</value>
        public YesNo ObsInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SaveStateParams field.
        /// </summary>
        /// <value>The save state params.</value>
        public String SaveStateParams
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SGID field.
        /// </summary>
        /// <value>The SGID.</value>
        public String SGID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubFilingType field.
        /// </summary>
        /// <value>The type of the sub filing.</value>
        public String SubFilingType
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

            EFilingDraftStateEntity toCompareWith = obj as EFilingDraftStateEntity;
            return toCompareWith == null ? false : ((this.EFilingDraftStateId == toCompareWith.EFilingDraftStateId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.EFilingDraftStateId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}