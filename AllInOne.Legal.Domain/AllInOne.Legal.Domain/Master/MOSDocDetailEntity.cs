#region Header

/*****************************************************************************************************
* Description : This file represents a standard MOSDocDetail entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   26/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MOSDocDetailEntity.cs
// Description: Represents a standard MOSDocDetailEntity entity.
// </summary>
// <copyright file= "MOSDocDetailEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MOSDocDetailEntity.
    /// </summary>
    [Serializable]
    public class MOSDocDetailEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MOSDocDetail"/> class.
        /// </summary>
        public MOSDocDetailEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the DocID field.
        /// </summary>
        /// <value>The doc ID.</value>
        public String DocID
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the ExtTime field.
        /// </summary>
        /// <value>The ext time.</value>
        public String ExtTime
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the OrderNo field.
        /// </summary>
        /// <value>The order no.</value>
        public String OrderNo
        {
            get;set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified object is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            MOSDocDetailEntity toCompareWith = obj as MOSDocDetailEntity;
            return toCompareWith == null ? false : ((this.DocID == toCompareWith.DocID));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.DocID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}