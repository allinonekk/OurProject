#region Header

/*****************************************************************************************************
 * Description : This file represents a standard RDocLawFirm.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 04/10/2010   		      Swaroop             	 	Updated
 *****************************************************************************************************/
// <summary>
// File: RDocLawFirmEntity.cs
// Description: Represents a standard RDocLawFirm.
// </summary>
// <copyright file= "RDocLawFirmEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Document
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for RDocLawFirm.
    /// It inherits from <see cref="AbstractDocId"/>
    /// </summary>
    [Serializable]
    public class RDocLawFirmEntity : AbstractDocId, IDocumentEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RDocLawFirmEntity"/> class.
        /// </summary>
        public RDocLawFirmEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

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
        /// Gets or sets the OwnerInd field.
        /// </summary>
        /// <remarks>The OwnerInd is <see cref="YesNo"/>.N when the doc is served to another LawFirm</remarks>
        /// <value>The owner ind.</value>
        public YesNo OwnerInd
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the RDLFId field.
        /// </summary>
        /// <value>The RDLF id.</value>
        public String RDLFId
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

            RDocLawFirmEntity toCompareWith = obj as RDocLawFirmEntity;
            return toCompareWith == null ? false : ((this.RDLFId == toCompareWith.RDLFId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.RDLFId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}