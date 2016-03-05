#region Header

/*****************************************************************************************************
* Description : This file represents a standard LACDocumentRemark entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   10/10/2010   		      Swaroop             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: LACDocumentRemarkEntity.cs
// Description: Represents a standard LACDocumentRemark entity.
// </summary>
// <copyright file= "LACDocumentRemarkEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LAP
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for LACDocumentRemark.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class LACDocumentRemarkEntity : AbstractLastModified, ILAPEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the LAC doc detail id.
        /// </summary>
        /// <value>The LAC doc detail id.</value>
        public String LACDocDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LACDocRemarkId field.
        /// </summary>
        /// <value>The LAC doc remark id.</value>
        public String LACDocRemarkId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Remarks field.
        /// </summary>
        /// <value>The remarks.</value>
        public String Remarks
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

            LACDocumentRemarkEntity toCompareWith = obj as LACDocumentRemarkEntity;
            return toCompareWith == null ? false : ((this.LACDocRemarkId == toCompareWith.LACDocRemarkId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LACDocRemarkId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}