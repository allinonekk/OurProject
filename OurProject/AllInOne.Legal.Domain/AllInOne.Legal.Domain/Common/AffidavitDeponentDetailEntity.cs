#region Header

/*****************************************************************************************************
* Description : This file represents a standard AffidavitDeponentDetail entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			            Author			        Description
*-----------------------------------------------------------------------------------------------------
*   14/11/2010                 Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: AffidavitDeponentDetailEntity.cs
// Description: Represents a standard AffidavitDeponentDetail entity.
// </summary>
// <copyright file= "AffidavitDeponentDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for AffidavitDeponentDetail.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class AffidavitDeponentDetailEntity : AbstractLastModified, ICommonEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the AffidavitDeponentDetailId field.
        /// </summary>
        /// <value>The affidavit deponent detail id.</value>
        public String AffidavitDeponentDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the AffidavitId field.
        /// </summary>
        /// <value>The affidavit id.</value>
        public Int64 AffidavitId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DeponentId field.
        /// </summary>
        /// <value>The deponent id.</value>
        public String DeponentId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DeponentName field.
        /// </summary>
        /// <value>The name of the deponent.</value>
        public String DeponentName
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

            AffidavitDeponentDetailEntity toCompareWith = obj as AffidavitDeponentDetailEntity;
            return toCompareWith == null ? false : ((this.AffidavitDeponentDetailId == toCompareWith.AffidavitDeponentDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.AffidavitDeponentDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}