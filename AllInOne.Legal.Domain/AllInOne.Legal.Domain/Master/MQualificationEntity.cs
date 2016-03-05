#region Header

/*****************************************************************************************************
* Description : This file represents a standard MQualification entity.
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
// File: MQualificationEntity.cs
// Description: Represents a standard MQualification entity.
// </summary>
// <copyright file= "MQualificationEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MQualificationEntity.
    /// </summary>
    [Serializable]
    public class MQualificationEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MQualification"/> class.
        /// </summary>
        public MQualificationEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the QualificationCode field.
        /// </summary>
        /// <value>The qualification code.</value>
        public String QualificationCode
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
            MQualificationEntity toCompareWith = obj as MQualificationEntity;
            return toCompareWith == null ? false : ((this.QualificationCode == toCompareWith.QualificationCode));
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
            toReturn ^= this.QualificationCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}