#region Header

/*****************************************************************************************************
* Description : This file represents a standard MPersonIDGroup entity.
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
// File: MPersonIDGroupEntity.cs
// Description: Represents a standard MPersonIDGroup entity.
// </summary>
// <copyright file= "MPersonIDGroupEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MPersonIDGroupEntity.
    /// </summary>
    [Serializable]
    public class MPersonIDGroupEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MPersonIDGroup"/> class.
        /// </summary>
        public MPersonIDGroupEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the IDGroupCode field.
        /// </summary>
        /// <value>The ID group code.</value>
        public String IDGroupCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the SeqNo field.
        /// </summary>
        /// <value>The seq no.</value>
        public Int32 SeqNo
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the UIDescription field.
        /// </summary>
        /// <value>The UI description.</value>
        public String UIDescription
        {
            get; set;
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
            MPersonIDGroupEntity toCompareWith = obj as MPersonIDGroupEntity;
            return toCompareWith == null ? false : ((this.IDGroupCode == toCompareWith.IDGroupCode));
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
            toReturn ^= this.IDGroupCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}