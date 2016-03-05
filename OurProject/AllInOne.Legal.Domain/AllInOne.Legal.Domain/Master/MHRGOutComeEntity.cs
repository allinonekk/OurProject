#region Header

/*****************************************************************************************************
* Description : This file represents a standard MHRGOutcome entity.
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
// File: MHRGOutcomeEntity.cs
// Description: Represents a standard MHRGOutcome entity.
// </summary>
// <copyright file= "MHRGOutcomeEntity.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Master
{
    using System;

    using AllInOne.Legal.Domain.Abstract;
    using AllInOne.Legal.Domain.Interfaces;

    /// <summary>
    /// Represents a standard domain entity for MHRGOutcome.
    /// </summary>
    [Serializable]
    public class MHRGOutComeEntity : AbstractMasterInfo, IMasterEntity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MHRGOutCome"/> class.
        /// </summary>
        public MHRGOutComeEntity()
            : base()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the HRGOutComeCode field.
        /// </summary>
        /// <value>The HRG out come code.</value>
        public String HRGOutComeCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the IsConcludedInd field.
        /// </summary>
        /// <value>The is concluded ind.</value>
        public String IsConcludedInd
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the IsInterfaced field.
        /// </summary>
        /// <value>The is interfaced.</value>
        public String IsInterfaced
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the OrderGenerateInd field.
        /// </summary>
        /// <value>The order generate ind.</value>
        public String OrderGenerateInd
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
            MHRGOutComeEntity toCompareWith = obj as MHRGOutComeEntity;
            return toCompareWith == null ? false : ((this.HRGOutComeCode == toCompareWith.HRGOutComeCode));
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
            toReturn ^= this.HRGOutComeCode.GetHashCode();
            return toReturn;
        }

        #endregion Methods
    }
}