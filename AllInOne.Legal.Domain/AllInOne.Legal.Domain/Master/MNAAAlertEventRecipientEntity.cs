#region Header

/*****************************************************************************************************
* Description : This file represents a standard MNAAAlertEventRecipient entity.
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
// File: MNAAAlertEventRecipientEntity.cs
// Description: Represents a standard MNAAAlertEventRecipientEntity entity.
// </summary>
// <copyright file= "MNAAAlertEventRecipientEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MNAAAlertEventRecipientEntity.
    /// </summary>
    [Serializable]
    public class MNAAAlertEventRecipientEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MNAAAlertEventRecipient"/> class.
        /// </summary>
        public MNAAAlertEventRecipientEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the AlertEventRecipientCode field.
        /// </summary>
        /// <value>The alert event recipient code.</value>
        public String AlertEventRecipientCode
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets the RecipientEnd field.
        /// </summary>
        /// <value>The recipient end.</value>
        public String RecipientEnd
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
            MNAAAlertEventRecipientEntity toCompareWith = obj as MNAAAlertEventRecipientEntity;
            return toCompareWith == null ? false : ((this.AlertEventRecipientCode == toCompareWith.AlertEventRecipientCode));
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
            toReturn ^= this.AlertEventRecipientCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}