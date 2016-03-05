#region Header

/*****************************************************************************************************
* Description : This file represents a standard LACUmbrellaUser entity.
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
// File: LACUmbrellaUserEntity.cs
// Description: Represents a standard LACUmbrellaUser entity.
// </summary>
// <copyright file= "LACUmbrellaUserEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.LAP
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for LACUmbrellaUser.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class LACUmbrellaUserEntity : AbstractLastModified, ILAPEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the LACUserCreationId field.
        /// </summary>
        /// <value>The LAC user creation id.</value>
        public String LACUserCreationId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SolicitorId field.
        /// </summary>
        /// <value>The solicitor id.</value>
        public Int64 SolicitorId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the UserId field.
        /// UserId of the solicitor, whose account is created.
        /// </summary>
        /// <value>The user id.</value>
        public String UserId
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

            LACUmbrellaUserEntity toCompareWith = obj as LACUmbrellaUserEntity;
            return toCompareWith == null ? false : ((this.LACUserCreationId == toCompareWith.LACUserCreationId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.LACUserCreationId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}