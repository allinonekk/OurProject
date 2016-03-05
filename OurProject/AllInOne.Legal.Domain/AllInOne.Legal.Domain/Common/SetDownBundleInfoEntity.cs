#region Header

/*****************************************************************************************************
* Description : This file represents a standard domain entity for SetDownBundleInfo.
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
// File: SetDownBundleInfoEntity.cs
// Description: Represents a standard domain entity for SetDownBundleInfo.
// </summary>
// <copyright file= "SetDownBundleInfoEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;

    /// <summary>
    /// Represents a standard domain entity for SetDownBundleInfo.
    /// It inherits from <see cref="AbstractDocIdSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class SetDownBundleInfoEntity : AbstractDocIdSubmissionGroup
    {
        #region Properties

        /// <summary>
        /// Gets or sets the PdfGenDetailId field.
        /// </summary>
        /// <value>The PDF gen detail id.</value>
        public String PdfGenDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SetDownBundleInfoId field.
        /// </summary>
        /// <value>The set down bundle info id.</value>
        public String SetDownBundleInfoId
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
            SetDownBundleInfoEntity toCompareWith = obj as SetDownBundleInfoEntity;
            return toCompareWith == null ? false : ((this.SetDownBundleInfoId == toCompareWith.SetDownBundleInfoId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SetDownBundleInfoId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}