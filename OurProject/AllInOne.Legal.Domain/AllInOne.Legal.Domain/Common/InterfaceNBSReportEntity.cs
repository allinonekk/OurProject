#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for ChildInfo.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   30/11/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: ChildInfoEntity.cs
// Description: Represents a standard domain entity for ChildInfo.
// </summary>
// <copyright file= "ChildInfoEntity.cs" company="AllInOne Pte Ltd">
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
    /// Represents a standard domain entity for ChildInfo.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class InterfaceNBSReportEntity : ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the GroundInfoId field.
        /// </summary>
        /// <value>The ground info id.</value>
        public String FileNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Level field.
        /// </summary>
        /// <value>The level.</value>
        public DateTime Date
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RequestedGrounds field.
        /// </summary>
        /// <value>The requested grounds.</value>
        public String FileNameLocation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SubLevel field.
        /// </summary>
        /// <value>The sub level.</value>
        public string FileType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the GroundInfoId field.
        /// </summary>
        /// <value>The ground info id.</value>
        public String ReportType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Level field.
        /// </summary>
        /// <value>The level.</value>
        public string LastmodifiedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RequestedGrounds field.
        /// </summary>
        /// <value>The requested grounds.</value>
        public DateTime LastModifiedDate
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

            InterfaceNBSReportEntity toCompareWith = obj as InterfaceNBSReportEntity;
            return toCompareWith == null ? false : ((this.FileNumber == toCompareWith.FileNumber));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.FileNumber.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}