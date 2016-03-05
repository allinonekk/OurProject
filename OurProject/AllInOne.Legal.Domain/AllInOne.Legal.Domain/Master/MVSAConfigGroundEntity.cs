#region Header

/*****************************************************************************************************
* Description : This file represents a standard MDesignation entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   25/08/2010   		      Nithin             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: MDesignationEntity.cs
// Description: Represents a standard MDesignation entity.
// </summary>
// <copyright file= "MDesignationEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MDesignation.
    /// </summary>
    [Serializable]
    public class MVSAConfigGroundEntity : AbstractLastModified, IMasterEntity
    {
       
        #region Properties

        /// <summary>
        /// Gets or sets the DSGCategory field.
        /// </summary>
        /// <value>The DSG category.</value>
        public String VSAConfigGroundsId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the DSGCode field.
        /// </summary>
        /// <value>The DSG code.</value>
        public String VSAConfigDetailId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the IsPAAllowed field.
        /// </summary>
        /// <value>The is PA allowed.</value>
        public Int32 Level
        {
            get; set;
        }


        public Int32? SubLevel
        {
            get;
            set;
        }

        public YesNo IsEnabled
        {
            get;
            set;
        }
        public String GroundsText
        {
            get;
            set;
        }

        public YesNo ObsInd
        {
            get;
            set;
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
            MVSAConfigGroundEntity toCompareWith = obj as MVSAConfigGroundEntity;
            return toCompareWith == null ? false : ((this.VSAConfigGroundsId == toCompareWith.VSAConfigGroundsId));
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
            toReturn ^= this.VSAConfigGroundsId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}