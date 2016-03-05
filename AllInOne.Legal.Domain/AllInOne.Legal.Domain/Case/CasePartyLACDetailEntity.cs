#region Header

/*************************************************************************************************************************
* Description : This file represents a standard CasePartyLACDetail entity.
*
*-------------------------------------------------------------------------------------------------------------------------
*	                                    File History
*-------------------------------------------------------------------------------------------------------------------------
*
*	Date			        Author			        Description
*-------------------------------------------------------------------------------------------------------------------------
* 22/02/2010                Nithin             	Created
*************************************************************************************************************************/
// <summary>
// File: CasePartyEntity.cs
// Description: Represents a standard CasePartyLACDetail entity.
// </summary>
// <copyright file= "CasePartyLACDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for CasePartyLACDetail.
    /// It inherits from <see cref="AbstractCasePartyCaseInfo"/>
    /// </summary>
    [Serializable]
    public class CasePartyLACDetailEntity : AbstractCaseParty, ICaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CPLACDetailId field.
        /// </summary>
        /// <value>The CPLACDetailId.</value>
        public String CPLACDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DocId field.
        /// </summary>
        /// <value>The DocId.</value>
        public String DocId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FiledUserType field.
        /// </summary>
        /// <value>The FiledUserType.</value>
        public FiledUserType FiledUserType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LACDocDetailId field.
        /// </summary>
        /// <value>The LACDocDetailId.</value>
        public String LACDocDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LACInfoId field.
        /// </summary>
        /// <value>The LACInfoId.</value>
        public String LACInfoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LACRefStatus field.
        /// </summary>
        /// <value>The LACRefStatus.</value>
        public LACRefStatus LACRefStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LFGroupCode field.
        /// </summary>
        /// <value>The LFGroupCode.</value>
        public LFGroupCode LFGroupCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the StartDate field.
        /// </summary>
        /// <value>The StartDate.</value>
        public DateTime StartDate
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

            CasePartyLACDetailEntity toCompareWith = obj as CasePartyLACDetailEntity;
            return toCompareWith == null ? false : ((this.CPLACDetailId == toCompareWith.CPLACDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.CPLACDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}