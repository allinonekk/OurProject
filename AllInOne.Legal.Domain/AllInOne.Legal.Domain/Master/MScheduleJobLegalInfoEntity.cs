#region Header

/*****************************************************************************************************
* Description : This file represents a standard MBankruptcyType entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   16/08/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MBankruptcyTypeEntity.cs
// Description: Represents a standard MBankruptcyType entity.
// </summary>
// <copyright file= "MBankruptcyTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MBankruptcyType.
    /// </summary>
    [Serializable]
    public class MScheduleJobLegalInfoEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MScheduleJobLegalInfoEntity"/> class.</summary>
        public MScheduleJobLegalInfoEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public System.String CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ForumId field. </summary>
        public System.String ForumId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FrequencyType field. </summary>
        public System.String FrequencyType
        {
            get;
            set;
        }

        /// <summary>Gets or sets the IsActive field. </summary>
        public YesNo IsActive
        {
            get;
            set;
        }

        /// <summary>Gets or sets the JobDescription field. </summary>
        public System.String JobDescription
        {
            get;
            set;
        }

        /// <summary>Gets or sets the JobGroup field. </summary>
        public System.String JobGroup
        {
            get;
            set;
        }

        /// <summary>Gets or sets the JobName field. </summary>
        public System.String JobName
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ScheduleJobLegalInfoId field. </summary>
        public System.String ScheduleJobLegalInfoId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubCaseTypeCode field. </summary>
        public System.String SubCaseTypeCode
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
            MScheduleJobLegalInfoEntity toCompareWith = obj as MScheduleJobLegalInfoEntity;
            return toCompareWith == null ? false : ((this.ScheduleJobLegalInfoId == toCompareWith.ScheduleJobLegalInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.ScheduleJobLegalInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}