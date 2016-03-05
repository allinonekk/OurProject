#region Header

/*****************************************************************************************************
* Description : This file represents a standard WorkitemRecipient entity.
*
*-----------------------------------------------------------------------------------------------------
*	                                    File History
*-----------------------------------------------------------------------------------------------------
*
*	Date			          Author			        Description
*-----------------------------------------------------------------------------------------------------
*   21/06/2011  		      CJ             	 	Created
*
*****************************************************************************************************/
// <summary>
// File: FEWorkitemRecipientEntity.cs
// Description: Represents a standard WorkitemRecipient entity (FE).
// </summary>
// <copyright file= "FEWorkitemRecipientEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.FrontEndSpecific
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for WorkitemDetails.
    /// It inherits from <see cref="AbstractLastModified"/>
    /// </summary>
    [Serializable]
    public class FEWorkitemRecipientEntity : AbstractLastModified, IFrontEndSpecificEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the FileRefNo field.
        /// </summary>
        /// <value>The FileRefNo.</value>
        public String FileRefNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LFID field.
        /// </summary>
        /// <value>The LFID.</value>
        public String LFID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SolicitorID field.
        /// </summary>
        /// <value>The SolicitorID.</value>
        public Int64? SolicitorID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Status field.
        /// </summary>
        /// <value>The Status.</value>
        public WorkItemRecipientStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the WorkitemGroupID field.
        /// </summary>
        /// <value>The Work item group id no.</value>
        public String WorkitemGroupID
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
            if (obj == null)
            {
                return false;
            }
            FEWorkitemRecipientEntity toCompareWith = obj as FEWorkitemRecipientEntity;
            return toCompareWith == null ? false : ((this.WorkitemGroupID == toCompareWith.WorkitemGroupID) && (this.LFID == toCompareWith.LFID));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.WorkitemGroupID.GetHashCode();
            toReturn ^= this.LFID.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}