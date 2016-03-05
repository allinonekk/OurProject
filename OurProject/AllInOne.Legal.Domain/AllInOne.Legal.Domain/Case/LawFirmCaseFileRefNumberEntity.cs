#region Header

/*****************************************************************************************************
 * Description : This file represents a standard LawFirmCaseFileRefNumber.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 04/10/2010   		      Swaroop             	 	Updated
 *****************************************************************************************************/
// <summary>
// File: LawFirmCaseFileRefNumberEntity.cs
// Description: Represents a standard LawFirmCaseFileRefNumber.
// </summary>
// <copyright file= "LawFirmCaseFileRefNumberEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Case
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for LawFirmCaseFileRefNumber.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class LawFirmCaseFileRefNumberEntity : AbstractCaseInfo, ICaseEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LawFirmCaseFileRefNumberEntity"/> class.
        /// </summary>
        public LawFirmCaseFileRefNumberEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the LFCFRNId field.
        /// </summary>
        /// <value>The LFCFRN id.</value>
        public String LFCFRNId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LFFileRefNumber field.
        /// </summary>
        /// <value>The LF file ref number.</value>
        public String LFFileRefNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LFID field.
        /// </summary>
        /// <value>The LFID.</value>
        public String LFID
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

            LawFirmCaseFileRefNumberEntity toCompareWith = obj as LawFirmCaseFileRefNumberEntity;
            return toCompareWith == null ? false : ((this.LFCFRNId == toCompareWith.LFCFRNId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LFCFRNId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}