#region Header

/*****************************************************************************************************
* Description : This file represents a standard MBillType entity.
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
// File: MBillTypeEntity.cs
// Description: Represents a standard MBillType entity.
// </summary>
// <copyright file= "MBillTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MBillType.
    /// </summary>
    [Serializable]
    public class MFormSignatureEntity : AbstractLastModified, IMasterEntity
    {
        #region Properties

        /// <summary>Gets or sets the ActCode field. </summary>
        public System.String ActCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CaseTypeCode field. </summary>
        public System.String CaseTypeCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CommencingDesignation field. </summary>
        public System.String CommencingDesignation
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CourtSeal field. </summary>
        public System.String CourtSeal
        {
            get;
            set;
        }

        /// <summary>Gets or sets the CourtSeal_Subsequent field. </summary>
        public System.String CourtSeal_Subsequent
        {
            get;
            set;
        }

        /// <summary>Gets or sets the DocCode field. </summary>
        public System.String DocCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the FormSignatureId field. </summary>
        public System.String FormSignatureId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ForumId field. </summary>
        public System.String ForumId
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Name field. </summary>
        public System.String Name
        {
            get;
            set;
        }

        /// <summary>Gets or sets the NonCommencingDesignation field. </summary>
        public System.String NonCommencingDesignation
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ProvisionCode field. </summary>
        public System.String ProvisionCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the ProvisionNo field. </summary>
        public System.String ProvisionNo
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Signature field. </summary>
        public System.String Signature
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubProvisionCode field. </summary>
        public System.String SubProvisionCode
        {
            get;
            set;
        }

        /// <summary>Gets or sets the SubProvisionNo field. </summary>
        public System.String SubProvisionNo
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
            if (obj == null)
            {
                return false;
            }
            MFormSignatureEntity toCompareWith = obj as MFormSignatureEntity;
            return toCompareWith == null ? false : ((this.FormSignatureId == toCompareWith.FormSignatureId));
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
            toReturn ^= this.FormSignatureId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}