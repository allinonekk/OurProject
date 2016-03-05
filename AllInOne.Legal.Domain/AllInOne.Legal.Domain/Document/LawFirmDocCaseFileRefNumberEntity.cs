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

namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for LawFirmCaseFileRefNumber.
    /// It inherits from <see cref="AbstractCaseInfo"/>
    /// </summary>
    [Serializable]
    public class LawFirmDocCaseFileRefNumberEntity : AbstractCaseInfo, IDocumentEntity
    {
       

        #region Properties

        /// <summary>
        /// Gets or sets the LFDCFRNId field.
        /// </summary>
        /// <value>The LFDCFRNId.</value>
        public String LFDCFRNId
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

        public string SubmissionGroupId
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

            LawFirmDocCaseFileRefNumberEntity toCompareWith = obj as LawFirmDocCaseFileRefNumberEntity;
            return toCompareWith == null ? false : ((this.LFDCFRNId == toCompareWith.LFDCFRNId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LFDCFRNId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}