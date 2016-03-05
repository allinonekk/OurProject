#region Header

/*****************************************************************************************************
* Description : This file represents a standard MCourtType entity.
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
// File: MCourtTypeEntity.cs
// Description: Represents a standard MCourtType entity.
// </summary>
// <copyright file= "MCourtTypeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MCourtType.
    /// </summary>
    [Serializable]
    public class MCourtTypeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MCourtType"/> class.
        /// </summary>
        public MCourtTypeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the CourtId field.
        /// </summary>
        /// <value>The court Id.</value>
        public String CourtId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the CourtSeal field.
        /// </summary>
        /// <value>The CourtSeal.</value>
        public String CourtSeal
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the SeqNo field.
        /// </summary>
        /// <value>The seq no.</value>
        public Int32 SeqNo
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
            MCourtTypeEntity toCompareWith = obj as MCourtTypeEntity;
            return toCompareWith == null ? false : ((this.CourtId == toCompareWith.CourtId));
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
            toReturn ^= this.CourtId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}