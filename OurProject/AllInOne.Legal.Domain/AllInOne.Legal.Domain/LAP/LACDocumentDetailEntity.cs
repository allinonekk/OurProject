#region Header

/*****************************************************************************************************
* Description : This file represents a standard LACDocumentDetail entity.
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
// File: LACDocumentDetailEntity.cs
// Description: Represents a standard LACDocumentDetail entity.
// </summary>
// <copyright file= "LACDocumentDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LAP
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for LACDocumentDetail.
    /// It inherits from <see cref="AbstractLACInfoDocId"/>
    /// </summary>
    [Serializable]
    public class LACDocumentDetailEntity : AbstractLACInfoDocId, ILAPEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ExpiredDateTime field.
        /// </summary>
        /// <value>The expired date time.</value>
        public DateTime? ExpiredDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ExpiryDateTime field.
        /// </summary>
        /// <value>The expiry date time.</value>
        public DateTime? ExpiryDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IssuedDateTime field.
        /// </summary>
        /// <value>The issued date time.</value>
        public DateTime? IssuedDateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LACDocDetailId field.
        /// </summary>
        /// <value>The LAC doc detail id.</value>
        public String LACDocDetailId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LACDocStatus field.
        /// </summary>
        /// <value>The LAC doc status.</value>
        public LACDocStatus LACDocStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the VersionNo field.
        /// </summary>
        /// <value>The version no.</value>
        public Decimal? VersionNo
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

            LACDocumentDetailEntity toCompareWith = obj as LACDocumentDetailEntity;
            return toCompareWith == null ? false : ((this.LACDocDetailId == toCompareWith.LACDocDetailId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LACDocDetailId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}