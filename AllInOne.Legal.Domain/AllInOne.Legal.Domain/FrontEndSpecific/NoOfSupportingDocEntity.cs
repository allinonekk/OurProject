#region Header

/*****************************************************************************************************
* Description : This file represents a standard NoOfSupportingDoc entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   07/10/2010  		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: NoOfSupportingDocEntity.cs
// Description: Represents a standard NoOfSupportingDoc entity.
// </summary>
// <copyright file= "NoOfSupportingDocEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;
    using AllInOne.Legal.Domain.Master;

    /// <summary>
    /// Represents a standard domain entity for NoOfSupportingDoc.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class NoOfSupportingDocEntity : AbstractSubmissionGroup, IFrontEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Count field.
        /// </summary>
        /// <value>The count.</value>
        public Int32 Count
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the DocCode field.
        /// </summary>
        /// <value>The M doc code.</value>
        public MDocCodeEntity MDocCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SupdocId field.
        /// </summary>
        /// <value>The supdoc id.</value>
        public String SupdocId
        {
            get; set;
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

            NoOfSupportingDocEntity toCompareWith = obj as NoOfSupportingDocEntity;
            return toCompareWith == null ? false : ((this.SupdocId == toCompareWith.SupdocId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SupdocId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}