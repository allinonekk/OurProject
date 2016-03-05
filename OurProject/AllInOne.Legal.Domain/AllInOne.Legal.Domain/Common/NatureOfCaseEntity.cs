#region Header

/*****************************************************************************************************
 * Description : This file represents a standard NatureOfCase.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 25/09/2010   		      Swaroop             	 	Updated
 *****************************************************************************************************/
// <summary>
// File: NatureOfCaseEntity.cs
// Description: Represents a standard NatureOfCase.
// </summary>
// <copyright file= "NatureOfCaseEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for NatureOfCase.
    /// It inherits from <see cref="AbstractCaseInfoSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class NatureOfCaseEntity : AbstractCaseInfoSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NatureOfCaseEntity"/> class.
        /// </summary>
        public NatureOfCaseEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The item no.</value>
        public Decimal ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the MainNOCInd field.
        /// </summary>
        /// <value>The main NOC ind.</value>
        public YesNo MainNOCInd
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the navigator which is mapped onto the association 'Common.NatureOfCase.MNOC - Master.MNOC.NatureOfCases (m:1)'
        /// </summary>
        /// <value>The MNOC.</value>
        public MNOCEntity MNatureOfCase
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the NatureOfCaseId field.
        /// </summary>
        /// <value>The nature of case id.</value>
        public String NatureOfCaseId
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
        /// Gets or sets the OtherText field.
        /// </summary>
        /// <value>The other text.</value>
        public String OtherText
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

            NatureOfCaseEntity toCompareWith = obj as NatureOfCaseEntity;
            return toCompareWith == null ? false : ((this.NatureOfCaseId == toCompareWith.NatureOfCaseId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.NatureOfCaseId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}