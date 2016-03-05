#region Header

/*****************************************************************************************************
 * Description : This file represents a standard OtherITMO.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 20/09/2010                 Japheth             	 	Created
 * 25/09/2010   		      Swaroop             	 	Updated
 *****************************************************************************************************/
// <summary>
// File: OtherITMOEntity.cs
// Description: Represents a standard OtherITMO.
// </summary>
// <copyright file= "OtherITMOEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Common
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for OtherITMO.
    /// It inherits from <see cref="AbstractSubmissionGroup"/>
    /// </summary>
    [Serializable]
    public class OtherITMOEntity : AbstractSubmissionGroup, ICommonEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherITMOEntity"/> class.
        /// </summary>
        public OtherITMOEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the ItemNo field.
        /// </summary>
        /// <value>The item no.</value>
        public Int32 ItemNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OtherITMOId field.
        /// </summary>
        /// <value>The other ITMO id.</value>
        public String OtherITMOId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the OtherText field.
        /// </summary>
        /// <value>The other text.</value>
        public String OtherText
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

            OtherITMOEntity toCompareWith = obj as OtherITMOEntity;
            return toCompareWith == null ? false : ((this.OtherITMOId == toCompareWith.OtherITMOId));
        }

        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.OtherITMOId.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}